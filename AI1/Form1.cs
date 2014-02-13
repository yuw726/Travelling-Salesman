using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AI1
{
    public partial class Form1 : Form
    {
        bool interrupt_sim = true;                      // Флаг прерывания симуляции
        Random rand = new Random();                     // Генератор случайных чисел

        List<city> inhabitants;                         // Множество городов
        List<cityList> roadways = new List<cityList>(); // Множество последовательностей путей
        int best_roadway = 0;                           // Номер лучшей последовательности
        long best_fitness;                              // Значение функции приспособленности лучшей последовательности

        Image cityImage;                                // Тут происходит рисование
        Graphics graphics;                              // Это содержит стандартные функции рисования

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Основная функция симуляции алгоритма
        /// </summary>
        /// <param name="obj">Нужен для распараллеливания гуи и алгоритма</param>
        private void StartSimulation(Object obj)
        {
            if (radioButton1.Checked) PopulateArea();   
            DrawCityList();
            CreateRoadWays();

            int i = 0;
            while (!interrupt_sim && (i != numericUpDownIterations.Value))
            {
                DoCrossover();
                DoMutation();
                KillTheWeakest();
                if (interrupt_sim) { break; }
                ++i;
            }
            if (checkBox1.Checked)
            {
                cityImage = null;
                DrawCityList();
            }
            DrawRoadWay();

            // 
            //string name = "Старт";
            //if (button1.InvokeRequired)
            //{
            //    button1.Invoke(new MethodInvoker(delegate { button1.Text = name; }));
            //    interrupt_sim = true;
            //}
        }

        /// <summary>
        /// Функция заселения области - создание городов
        /// </summary>
        private void PopulateArea()
        {
            inhabitants = new List<city>(); 

            for (int j = 0; j != numericUpDownCities.Value; j++)
            {
                city newCity = new city();
                newCity.x = rand.Next(pictureBox1.Width);
                newCity.y = rand.Next(pictureBox1.Height);
                newCity.number = j + 1;
                    
                inhabitants.Add(newCity);
            }
        }

        /// <summary>
        /// Функция создания путей - множества способов обойти все города
        /// Предполагается, что все города связаны дорогами
        /// </summary>
        private void CreateRoadWays()
        {
            if (inhabitants == null || inhabitants.Count == 0)  
            {
                MessageBox.Show("Нечего симулировать. Количество городов равно нулю.");
                return;
            }
            List<city> availableCities = new List<city>();      // Список доступных городов. Нужен для исключения 
                                                                // возможности повторения города в одном пути.

            roadways.Clear();                                   // Очищаем список путей - начата новая симуляция

            for (int i = 0; i != numericUpDownIndivids.Value; i++)
            {
                availableCities.Clear();
                availableCities = inhabitants.ToList<city>();
                cityList new_roadway = new cityList();          // Путь, который мы будем добавлять в список путей roadways
                new_roadway.citySequence = new List<city>();

                while (availableCities.Count != 0)
                {                                               // Выбор и добавление города
                    int city2add = rand.Next(availableCities.Count);
                    new_roadway.citySequence.Add(availableCities[city2add]);
                    availableCities.Remove(availableCities[city2add]);
                }
                roadways.Add(new_roadway);
                if (interrupt_sim) { break; }                   // Для непредвиденного нажатия кнопки "Стоп"
            }
        }

        /// <summary>
        /// Функция селекции и скрещивания
        /// </summary>
        private void DoCrossover()
        {
            List<cityList> availableIndividuals = new List<cityList>();
            availableIndividuals = roadways.ToList<cityList>();
            
            for (int i = 0; i != availableIndividuals.Count; )
            {
                // Селекция случайным образом
                cityList parent1 = availableIndividuals[rand.Next(availableIndividuals.Count)];
                availableIndividuals.Remove(parent1);
                cityList parent2 = availableIndividuals[rand.Next(availableIndividuals.Count)];
                availableIndividuals.Remove(parent2);

                // Собственно скрещивание
                int crossover_pos = rand.Next(parent1.citySequence.Count);     // Позиция кроссовера
                city[] par1_head = new city[crossover_pos];                    // Голова первого родителя (жуть...)
                parent1.citySequence.CopyTo(0, par1_head, 0, crossover_pos);   // Это часть последовательности до точки скрещивания
                city[] par2_head = new city[crossover_pos];                    // Голова второго родителя
                parent2.citySequence.CopyTo(0, par2_head, 0, crossover_pos);

                cityList child1 = new cityList();                              // Дети
                cityList child2 = new cityList();
                child1.citySequence = new List<city>();
                child2.citySequence = new List<city>();

                child1.citySequence.AddRange(par1_head);                       // Голова остаётся
                child2.citySequence.AddRange(par2_head);

                int one_more_iterator = 0;                                     // Обмен хвостами
                while (one_more_iterator < parent2.citySequence.Count)
                {                                                              // Если в хвосте повторяющийся город, берём
                                                                               // первый неповторяющийся с начала второго родителя
                    if (!child1.citySequence.Contains(parent2.citySequence[one_more_iterator]))
                    child1.citySequence.Add(parent2.citySequence[one_more_iterator]);
                    ++one_more_iterator;
                }

                one_more_iterator = 0;                                         // Аналогично
                while (one_more_iterator < parent1.citySequence.Count)
                {
                    if (!child2.citySequence.Contains(parent1.citySequence[one_more_iterator])) 
                    child2.citySequence.Add(parent1.citySequence[one_more_iterator]);
                    ++one_more_iterator;
                }

                roadways.Add(child1);
                roadways.Add(child2);
            }
        }

        /// <summary>
        /// Функция мутации
        /// </summary>
        private void DoMutation()
        {
            for (int i = 0; i != numericUpDownIndivids.Value; i++)
            {
                if (rand.Next(100000) <= numericUpDownMutation.Value)   // Определение события мутации
                {
                    int mutant_gene1 = rand.Next(roadways[i].citySequence.Count);   // Номера мутирующих генов
                    int mutant_gene2 = rand.Next(roadways[i].citySequence.Count);
                    city exchange = roadways[i].citySequence[mutant_gene1];
                    roadways[i].citySequence[mutant_gene1] = roadways[i].citySequence[mutant_gene2];
                    roadways[i].citySequence[mutant_gene2] = exchange;
                }
                if (interrupt_sim) { break; }
            }
        }

        /// <summary>
        /// Функция отсеивания "слабых" последовательностей (особей)
        /// </summary>
        private void KillTheWeakest()
        {
            int thebest = 0;                                        // Номер лучшей последовательности
            List<cityList> bestindivids = new List<cityList>();     // Список лучших индивидов
            int half = (int)(roadways.Count + 1) / 2;               // Необходимо убрать половину особей для восстановления 
                                                                    // исходного размера популяции
            List<cityList> backup = new List<cityList>();           // Бэкап для экстренного выхода из функции
            backup = roadways.ToList<cityList>();

            for (int i = 0; i != half; i++)
            {
                thebest = ChooseTheBest();
                bestindivids.Add(roadways[thebest]);
                roadways.Remove(roadways[thebest]);
                if (interrupt_sim) { roadways = backup.ToList<cityList>(); return; }
            }

            roadways.Clear();
            roadways = bestindivids.ToList<cityList>();
            toolStripStatusLabel1.Text = "Последовательность # " + best_roadway + ", путь = " + best_fitness;
            if (checkBox1.Checked)
            {
                cityImage = null;
                DrawCityList();
                DrawRoadWay();
            }
        }

        /// <summary>
        /// Функция выбора наиболее приспособленных особей
        /// </summary>
        /// <returns> Номер лучшей последовательности </returns>
        private int ChooseTheBest()
        {
            best_roadway = 0;
            best_fitness = roadways[0].GetFitness();
            for (int i = 0; i != roadways.Count; i++)
            {
                long temp_fitness = roadways[i].GetFitness();
                if (temp_fitness < best_fitness)
                {
                    best_roadway = i;
                    best_fitness = temp_fitness;
                }
            }

            return best_roadway;
        }

        // -------------------------------------------------------------------
        // Функции визуализации

        /// <summary>
        /// Функция рисования городов
        /// </summary>
        private void DrawCityList()
        {
            cityImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(cityImage);

            if (inhabitants != null)
            foreach (city city2draw in inhabitants)
            {
                graphics.DrawEllipse(Pens.Black, city2draw.x - 2, city2draw.y - 2, 5, 5);
                graphics.FillEllipse(Brushes.Blue, city2draw.x - 2, city2draw.y - 2, 5, 5);
            }

            pictureBox1.Image = cityImage;
        }

        /// <summary>
        /// Функция рисования дорог
        /// </summary>
        private void DrawRoadWay()
        {
            Thread.Sleep(50);   // Ожидаем освобождения cityImage
            try
            {
                if (cityImage == null) cityImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                graphics = Graphics.FromImage(cityImage);
                for (int i = 0; i != inhabitants.Count - 1; i++)
                {
                    graphics.DrawLine(Pens.Black, roadways[best_roadway].citySequence[i].x, roadways[best_roadway].citySequence[i].y,
                                                  roadways[best_roadway].citySequence[i + 1].x, roadways[best_roadway].citySequence[i + 1].y);
                }
                graphics.DrawLine(Pens.Black, roadways[best_roadway].citySequence[inhabitants.Count - 1].x,
                                              roadways[best_roadway].citySequence[inhabitants.Count - 1].y,
                                              roadways[best_roadway].citySequence[0].x, roadways[best_roadway].citySequence[0].y);

                pictureBox1.Image = cityImage;
            }
            catch
            {
                MessageBox.Show("Невозможно начисовать карту путей. Симуляция прервана преждевременно.", "Ошибка");
            }
        }

        // -------------------------------------------------------------------
        // Интерфейс

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDownCities.Enabled = false;
            }
            else
            {
                numericUpDownCities.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (interrupt_sim)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(StartSimulation));
                button1.Text = "Стоп";
                interrupt_sim = false;
                toolStripStatusLabel1.Text = "Производится рассчёт путей...";
            }
            else
            {
                button1.Text = "Старт";
                toolStripStatusLabel1.Text = "Готово";
                interrupt_sim = true;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                city newCity = new city();
                newCity.x = e.X;
                newCity.y = e.Y;

                if (inhabitants == null)
                {
                    inhabitants = new List<city>();
                    newCity.number = 1;
                }
                else
                {
                    newCity.number = inhabitants.Count + 1;
                }

                inhabitants.Add(newCity);

                DrawCityList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inhabitants = new List<city>();
            DrawCityList();
        }
    }
}

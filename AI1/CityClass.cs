using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI1
{
    struct city
    {
        public int number;              // Номер города
        public int x;                   // Координаты города
        public int y;                   //
    }

    class cityList
    {
        public List<city> citySequence; // Последовательность городов (путь коммивояжера)

        public long GetFitness()
        {
            long length = 0;
            for (int i = 0; i != citySequence.Count - 1; i++)
            {
                length += (int)Math.Sqrt(Math.Pow((citySequence[i].x - citySequence[i + 1].x), 2D) +
                                       Math.Pow((citySequence[i].y - citySequence[i + 1].y), 2D));
            }
            length += (int)Math.Sqrt(Math.Pow((citySequence[citySequence.Count-1].x - citySequence[0].x), 2D) +
                                     Math.Pow((citySequence[citySequence.Count-1].y - citySequence[0].y), 2D));
            return length;
        }
    };
    
}

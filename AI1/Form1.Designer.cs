namespace AI1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCities = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownIndivids = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMutation = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCities)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndivids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutation)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownCities);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(518, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные условия";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(163, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Вручную";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(163, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Случайно";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбор позиции";
            // 
            // numericUpDownCities
            // 
            this.numericUpDownCities.Location = new System.Drawing.Point(165, 93);
            this.numericUpDownCities.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCities.Name = "numericUpDownCities";
            this.numericUpDownCities.Size = new System.Drawing.Size(117, 22);
            this.numericUpDownCities.TabIndex = 1;
            this.numericUpDownCities.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество городов";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.numericUpDownIterations);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(518, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Симуляция";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(282, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Рисовать промежуточные результаты";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Location = new System.Drawing.Point(165, 68);
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(117, 22);
            this.numericUpDownIterations.TabIndex = 4;
            this.numericUpDownIterations.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество итераций";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 375);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(822, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(194, 20);
            this.toolStripStatusLabel1.Text = "Програма готова к работе";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownIndivids);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numericUpDownMutation);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(518, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 93);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры генетического алгоритма";
            // 
            // numericUpDownIndivids
            // 
            this.numericUpDownIndivids.Location = new System.Drawing.Point(165, 31);
            this.numericUpDownIndivids.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIndivids.Name = "numericUpDownIndivids";
            this.numericUpDownIndivids.Size = new System.Drawing.Size(117, 22);
            this.numericUpDownIndivids.TabIndex = 3;
            this.numericUpDownIndivids.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество особей";
            // 
            // numericUpDownMutation
            // 
            this.numericUpDownMutation.Location = new System.Drawing.Point(220, 67);
            this.numericUpDownMutation.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMutation.Name = "numericUpDownMutation";
            this.numericUpDownMutation.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownMutation.TabIndex = 1;
            this.numericUpDownMutation.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Вероятность мутации, 0.001%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 415);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Задача коммивояжера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCities)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndivids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownIndivids;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMutation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


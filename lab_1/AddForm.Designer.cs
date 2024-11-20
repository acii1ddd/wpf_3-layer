namespace lab_1
{
    partial class AddForm
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            tabPage3 = new TabPage();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(18, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(489, 340);
            tabControl1.TabIndex = 1;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(481, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Добавить пассажира";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(70, 228);
            label5.Name = "label5";
            label5.Size = new Size(219, 21);
            label5.TabIndex = 7;
            label5.Text = "Введите паспортные данные:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(70, 158);
            label4.Name = "label4";
            label4.Size = new Size(216, 21);
            label4.TabIndex = 6;
            label4.Text = "Введите телефон пассажира:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(70, 89);
            label3.Name = "label3";
            label3.Size = new Size(229, 21);
            label3.TabIndex = 5;
            label3.Text = "Введите фамилию пассажира: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(70, 23);
            label2.Name = "label2";
            label2.Size = new Size(188, 21);
            label2.TabIndex = 4;
            label2.Text = "Введите имя пассажира: ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(481, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить билет";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(289, 92);
            label11.Name = "label11";
            label11.Size = new Size(127, 15);
            label11.TabIndex = 11;
            label11.Text = "Введите номер места:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(289, 26);
            label10.Name = "label10";
            label10.Size = new Size(132, 15);
            label10.TabIndex = 10;
            label10.Text = "Введите номер вагона:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 212);
            label9.Name = "label9";
            label9.Size = new Size(137, 15);
            label9.TabIndex = 9;
            label9.Text = "Введите время приезда:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 152);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 8;
            label8.Text = "Введите время выезда:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 92);
            label7.Name = "label7";
            label7.Size = new Size(154, 15);
            label7.TabIndex = 7;
            label7.Text = "Введите точку назначения:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 26);
            label6.Name = "label6";
            label6.Size = new Size(161, 15);
            label6.TabIndex = 6;
            label6.Text = "Введите точку отправления:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(289, 44);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(159, 23);
            textBox10.TabIndex = 5;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(289, 110);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(159, 23);
            textBox9.TabIndex = 4;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(31, 230);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(214, 23);
            textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(31, 170);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(214, 23);
            textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(31, 110);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 23);
            textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(31, 44);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 23);
            textBox5.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox13);
            tabPage3.Controls.Add(textBox12);
            tabPage3.Controls.Add(textBox11);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(481, 312);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Добавить поезд";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(57, 111);
            label14.Name = "label14";
            label14.Size = new Size(149, 15);
            label14.TabIndex = 5;
            label14.Text = "Введите количество мест:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(57, 176);
            label13.Name = "label13";
            label13.Size = new Size(167, 15);
            label13.TabIndex = 4;
            label13.Text = "Введите количество вагонов:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(57, 39);
            label12.Name = "label12";
            label12.Size = new Size(107, 15);
            label12.TabIndex = 3;
            label12.Text = "Введите маршрут:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(57, 129);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(337, 23);
            textBox13.TabIndex = 2;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(57, 194);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(337, 23);
            textBox12.TabIndex = 1;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(57, 57);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(337, 23);
            textBox11.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(513, 311);
            button1.Name = "button1";
            button1.Size = new Size(149, 41);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 364);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label7;
        private Label label6;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}
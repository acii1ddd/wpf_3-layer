namespace lab_1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            выводToolStripMenuItem = new ToolStripMenuItem();
            пассажирыToolStripMenuItem = new ToolStripMenuItem();
            билетыToolStripMenuItem = new ToolStripMenuItem();
            поезадToolStripMenuItem = new ToolStripMenuItem();
            добавлениеToolStripMenuItem = new ToolStripMenuItem();
            пассажирыToolStripMenuItem2 = new ToolStripMenuItem();
            билетыToolStripMenuItem1 = new ToolStripMenuItem();
            поездаToolStripMenuItem = new ToolStripMenuItem();
            удалениеToolStripMenuItem = new ToolStripMenuItem();
            пассажирыToolStripMenuItem1 = new ToolStripMenuItem();
            билетыToolStripMenuItem2 = new ToolStripMenuItem();
            поездаToolStripMenuItem1 = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            пассажирыToolStripMenuItem3 = new ToolStripMenuItem();
            билетыToolStripMenuItem3 = new ToolStripMenuItem();
            поездаToolStripMenuItem2 = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(776, 193);
            dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { выводToolStripMenuItem, добавлениеToolStripMenuItem, удалениеToolStripMenuItem, поискToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // выводToolStripMenuItem
            // 
            выводToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пассажирыToolStripMenuItem, билетыToolStripMenuItem, поезадToolStripMenuItem });
            выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            выводToolStripMenuItem.Size = new Size(54, 20);
            выводToolStripMenuItem.Text = "Вывод";
            // 
            // пассажирыToolStripMenuItem
            // 
            пассажирыToolStripMenuItem.Name = "пассажирыToolStripMenuItem";
            пассажирыToolStripMenuItem.Size = new Size(139, 22);
            пассажирыToolStripMenuItem.Text = "Пассажиры";
            пассажирыToolStripMenuItem.Click += пассажирыToolStripMenuItem_Click;
            // 
            // билетыToolStripMenuItem
            // 
            билетыToolStripMenuItem.Name = "билетыToolStripMenuItem";
            билетыToolStripMenuItem.Size = new Size(139, 22);
            билетыToolStripMenuItem.Text = "Билеты";
            билетыToolStripMenuItem.Click += билетыToolStripMenuItem_Click;
            // 
            // поезадToolStripMenuItem
            // 
            поезадToolStripMenuItem.Name = "поезадToolStripMenuItem";
            поезадToolStripMenuItem.Size = new Size(139, 22);
            поезадToolStripMenuItem.Text = "Поезда";
            поезадToolStripMenuItem.Click += поездаToolStripMenuItem_Click;
            // 
            // добавлениеToolStripMenuItem
            // 
            добавлениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пассажирыToolStripMenuItem2, билетыToolStripMenuItem1, поездаToolStripMenuItem });
            добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            добавлениеToolStripMenuItem.Size = new Size(86, 20);
            добавлениеToolStripMenuItem.Text = "Добавление";
            // 
            // пассажирыToolStripMenuItem2
            // 
            пассажирыToolStripMenuItem2.Name = "пассажирыToolStripMenuItem2";
            пассажирыToolStripMenuItem2.Size = new Size(139, 22);
            пассажирыToolStripMenuItem2.Text = "Пассажиры";
            пассажирыToolStripMenuItem2.Click += пассажирToolStripMenuItem_Click;
            // 
            // билетыToolStripMenuItem1
            // 
            билетыToolStripMenuItem1.Name = "билетыToolStripMenuItem1";
            билетыToolStripMenuItem1.Size = new Size(139, 22);
            билетыToolStripMenuItem1.Text = "Билеты";
            билетыToolStripMenuItem1.Click += билетыToolStripMenuItem1_Click;
            // 
            // поездаToolStripMenuItem
            // 
            поездаToolStripMenuItem.Name = "поездаToolStripMenuItem";
            поездаToolStripMenuItem.Size = new Size(139, 22);
            поездаToolStripMenuItem.Text = "Поезда";
            поездаToolStripMenuItem.Click += поездаToolStripMenuItem_Click_1;
            // 
            // удалениеToolStripMenuItem
            // 
            удалениеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пассажирыToolStripMenuItem1, билетыToolStripMenuItem2, поездаToolStripMenuItem1 });
            удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            удалениеToolStripMenuItem.Size = new Size(71, 20);
            удалениеToolStripMenuItem.Text = "Удаление";
            // 
            // пассажирыToolStripMenuItem1
            // 
            пассажирыToolStripMenuItem1.Name = "пассажирыToolStripMenuItem1";
            пассажирыToolStripMenuItem1.Size = new Size(139, 22);
            пассажирыToolStripMenuItem1.Text = "Пассажиры";
            пассажирыToolStripMenuItem1.Click += пассажирыToolStripMenuItem1_Click;
            // 
            // билетыToolStripMenuItem2
            // 
            билетыToolStripMenuItem2.Name = "билетыToolStripMenuItem2";
            билетыToolStripMenuItem2.Size = new Size(139, 22);
            билетыToolStripMenuItem2.Text = "Билеты";
            билетыToolStripMenuItem2.Click += билетыToolStripMenuItem2_Click;
            // 
            // поездаToolStripMenuItem1
            // 
            поездаToolStripMenuItem1.Name = "поездаToolStripMenuItem1";
            поездаToolStripMenuItem1.Size = new Size(139, 22);
            поездаToolStripMenuItem1.Text = "Поезда";
            поездаToolStripMenuItem1.Click += поездаToolStripMenuItem1_Click;
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пассажирыToolStripMenuItem3, билетыToolStripMenuItem3, поездаToolStripMenuItem2 });
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(54, 20);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // пассажирыToolStripMenuItem3
            // 
            пассажирыToolStripMenuItem3.Name = "пассажирыToolStripMenuItem3";
            пассажирыToolStripMenuItem3.Size = new Size(139, 22);
            пассажирыToolStripMenuItem3.Text = "Пассажиры";
            пассажирыToolStripMenuItem3.Click += пассажирыToolStripMenuItem3_Click;
            // 
            // билетыToolStripMenuItem3
            // 
            билетыToolStripMenuItem3.Name = "билетыToolStripMenuItem3";
            билетыToolStripMenuItem3.Size = new Size(139, 22);
            билетыToolStripMenuItem3.Text = "Билеты";
            билетыToolStripMenuItem3.Click += билетыToolStripMenuItem3_Click;
            // 
            // поездаToolStripMenuItem2
            // 
            поездаToolStripMenuItem2.Name = "поездаToolStripMenuItem2";
            поездаToolStripMenuItem2.Size = new Size(139, 22);
            поездаToolStripMenuItem2.Text = "Поезда";
            поездаToolStripMenuItem2.Click += поездаToolStripMenuItem2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(448, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(441, 257);
            label1.Name = "label1";
            label1.Size = new Size(269, 28);
            label1.TabIndex = 4;
            label1.Text = "Выберите источник данных:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "ЛАБ 1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выводToolStripMenuItem;
        private ToolStripMenuItem добавлениеToolStripMenuItem;
        private ToolStripMenuItem удалениеToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem пассажирыToolStripMenuItem;
        private ToolStripMenuItem билетыToolStripMenuItem;
        private ToolStripMenuItem поезадToolStripMenuItem;
        private ToolStripMenuItem пассажирыToolStripMenuItem2;
        private ToolStripMenuItem билетыToolStripMenuItem1;
        private ToolStripMenuItem поездаToolStripMenuItem;
        private ToolStripMenuItem пассажирыToolStripMenuItem1;
        private ToolStripMenuItem билетыToolStripMenuItem2;
        private ToolStripMenuItem поездаToolStripMenuItem1;
        private ToolStripMenuItem пассажирыToolStripMenuItem3;
        private ToolStripMenuItem билетыToolStripMenuItem3;
        private ToolStripMenuItem поездаToolStripMenuItem2;
        private ComboBox comboBox1;
        private Label label1;
    }
}

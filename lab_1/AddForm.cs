using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public Passenger passToAdd { get; set; }
        public Ticket ticketToAdd { get; set; }
        public Train trainToAdd { get; set; }

        private TabPage currentTab;

        public int startTabInd { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                       string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                    {
                        MessageBox.Show("Заполните все поля.");
                        return;
                    }

                    passToAdd = new Passenger
                    {
                        FirstName = textBox1.Text,
                        SecondName = textBox2.Text,
                        Phone = textBox3.Text,
                        PassportData = textBox4.Text
                    };
                    this.DialogResult = DialogResult.OK;
                    break;

                case 1:
                    if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) ||
                       string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text) ||
                       string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox10.Text))
                    {
                        MessageBox.Show("Заполните все поля.");
                        return;
                    }

                    if (!int.TryParse(textBox9.Text, out int wagonNumber))
                    {
                        MessageBox.Show("Введите корректное значение номера вагона.");
                        return;
                    }

                    if (!int.TryParse(textBox10.Text, out int placeNumber))
                    {
                        MessageBox.Show("Введите корректное значение номера места.");
                        return;
                    }

                    ticketToAdd = new Ticket
                    {
                        Source = textBox5.Text,
                        Destination = textBox6.Text,
                        StartTime = DateTime.Parse(textBox7.Text),
                        ArrivalTime = DateTime.Parse(textBox8.Text),
                        WagonNumber = int.Parse(textBox10.Text),
                        PlaceNumber = int.Parse(textBox9.Text)
                    };
                    this.DialogResult = DialogResult.OK;
                    break;

                case 2:
                    if (string.IsNullOrEmpty(textBox11.Text) || string.IsNullOrEmpty(textBox12.Text) || string.IsNullOrEmpty(textBox13.Text))
                    {
                        MessageBox.Show("Заполните все поля.");
                        return;
                    }

                    if (!int.TryParse(textBox13.Text, out int placeCount))
                    {
                        MessageBox.Show("Введите корректное значение количества мест.");
                        return;
                    }

                    if (!int.TryParse(textBox12.Text, out int wagonCount))
                    {
                        MessageBox.Show("Введите корректное значение количества вагонов.");
                        return;
                    }

                    trainToAdd = new Train
                    {
                        Route = textBox11.Text,
                        Capacity = int.Parse(textBox13.Text),
                        WagonCount = int.Parse(textBox12.Text)
                    };
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage != currentTab)
            {
                e.Cancel = true; // отмена выбора
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            currentTab = tabControl1.TabPages[startTabInd];
            tabControl1.SelectedTab = currentTab;
        }
    }
}

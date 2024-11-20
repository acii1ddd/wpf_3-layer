using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winFormsUI
{
    public partial class SearchForm : Form
    {
        public int indToReturn { get; set; }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Поле не должно быть пустым.");
                return;
            }
            if (int.TryParse(textBox1.Text, out int parsedValue))
            {
                indToReturn = parsedValue;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }
    }
}

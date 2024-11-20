using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class DeleteForm : Form
    {
        private List<int> idList = new List<int>();
        public int indToDelete { get; set; }

        public DeleteForm(List<int> idList)
        {
            InitializeComponent();
            this.idList = idList;
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = idList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                indToDelete = int.Parse(comboBox1.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

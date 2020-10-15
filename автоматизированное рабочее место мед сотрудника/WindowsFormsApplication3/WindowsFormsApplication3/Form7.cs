using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form7 : Form
    {
        DAL dal = new DAL();
        public Form7()
        {
            InitializeComponent();
            ArrayList allBolezni = dal.GetAllBol();
            dataGridView1.DataSource = allBolezni;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Шаблон"].Visible = false;
           // textBox1.Text = dataGridView1.CurrentRow.Cells["Шаблон"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Шаблон"].Value.ToString();
        }
    }
}

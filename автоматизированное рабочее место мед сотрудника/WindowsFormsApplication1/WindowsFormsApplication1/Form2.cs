using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        DAL dal = new DAL();
        public Form2()
        {
            InitializeComponent();
            ArrayList PriemPacients = dal.GetPriemPacients();

            dataGridView1.DataSource = PriemPacients;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 newForm1 = new Form1();
            newForm1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 newForm3 = new Form3();
            newForm3.ShowDialog();
            this.Close();
        }
    }
}

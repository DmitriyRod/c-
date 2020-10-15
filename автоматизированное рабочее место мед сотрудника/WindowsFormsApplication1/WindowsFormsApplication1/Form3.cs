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
    public partial class Form3 : Form
    {
        DAL dal = new DAL();

        public Form3()
        {
            InitializeComponent();
            ArrayList allPacients = dal.GetAllPacients();

            dataGridView1.DataSource = allPacients;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 newForm1 = new Form1();
            newForm1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button3.BackColor = colorDialog1.Color;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
    }
}

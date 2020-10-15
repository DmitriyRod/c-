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
        Image File;
        public Form2()
        {
             
            InitializeComponent();
            for (int i = 1900; i <= 2070; i++)
            {
                comboBox3.Items.Add(i);
            }
            List<long> PriemPacients = dal.GetPriemPacients();
            long ID = 0;

            for (int i = 0; i < PriemPacients.Count; i++)
            {
                if (ID < PriemPacients[i])
                    ID = PriemPacients[i];
            }
            textBox16.Text = (ID + 1).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<long> PriemPacients = dal.GetPriemPacients();
            long ID = 0;
           
            for(int i=0;i < PriemPacients.Count;i++)
            {
             if (ID < PriemPacients[i])
             ID = PriemPacients[i];
            }
            
            if (dal.GetCurrentIDPacients(Convert.ToInt32(textBox16.Text)) == false)
            {
                dal.InsertPacientInBD(Convert.ToInt64(textBox16.Text), textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox10.Text, textBox4.Text + ' ' + textBox5.Text + ' ' + textBox6.Text + ' ' + textBox7.Text + ' ' + textBox8.Text + ' ' + textBox9.Text, textBox13.Text, textBox11.Text, textBox15.Text, textBox18.Text, textBox19.Text);
                dal.InsertPacientInBD(41);
                this.Close();
            }
            else
            {
                MessageBox.Show("Пациент с текущей картой существует");
                textBox16.Text = (ID + 1).ToString();
            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            //f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pictureBox1.Image = File;
            }
        }
    }
}

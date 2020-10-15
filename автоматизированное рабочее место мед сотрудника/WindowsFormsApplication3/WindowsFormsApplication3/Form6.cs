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

namespace WindowsFormsApplication3
{
    public partial class Form6 : Form
    {
        DAL dal = new DAL();
        public Form6()
        {
            InitializeComponent();
            ArrayList AllLek = dal.GetAllLek();
            dataGridView1.DataSource = AllLek;
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string abc = textBox4.Text;
            int num = Convert.ToInt32(abc);
            abc = dataGridView1.CurrentRow.Cells["Количество"].Value.ToString();
            int num2 = Convert.ToInt32(abc);
            int num3 = num2 + num;
            abc = num3.ToString();
            dal.InsertOldLekInBD(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value), dataGridView1.CurrentRow.Cells["Лекарственное средство"].Value.ToString(),abc);*/
            string abc = textBox4.Text;
            double num = Convert.ToDouble(abc);
            abc = dataGridView1.CurrentRow.Cells["Количество"].Value.ToString();
            double num2 = Convert.ToDouble(abc);
            double num3 = num2 + num;
            abc = num3.ToString();
            dal.InsertOldLekInBD(Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value), dataGridView1.CurrentRow.Cells["Лекарственное средство"].Value.ToString(), abc);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<long> LekID = dal.GetLekID();
            long ID = 0;

            for (int i = 0; i < LekID.Count; i++)
            {

                if (ID < LekID[i])
                    ID = LekID[i];
            }
            dal.InsertLekInBD(ID + 1, textBox3.Text, textBox2.Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList AllLek = dal.GetAllLekName(textBox1.Text);
            dataGridView1.DataSource = AllLek;
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form5 : Form
    {
        long IDBOL;
        
        DAL dal = new DAL();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            List<long> BolID = dal.GetBolID();
            long ID = 0;

            for (int i = 0; i < BolID.Count; i++)
            {

                if (ID < BolID[i])
                    ID = BolID[i];
            }
            dal.InsertBolInBD(ID + 1, textBox5.Text, textBox6.Text,textBox7.Text);
            IDBOL = ID + 1;
            button3.Visible = true;
            ArrayList AllLek = dal.GetAllLek();
            dataGridView1.DataSource = AllLek;
            dataGridView1.Columns["ID"].Visible = false;
            ArrayList AllBLek = dal.GetAllLekSkald(IDBOL);
            dataGridView2.DataSource = AllBLek;
            if(dataGridView2.RowCount > 0)
            {
                dataGridView2.Columns["ID"].Visible = false;
                dataGridView2.Columns["IDBol"].Visible = false;
            }
                

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ArrayList AllLek = dal.GetAllLekName(textBox1.Text);
            dataGridView1.DataSource = AllLek;
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*List<long> SkladID = dal.GetSKLADID();
            long ID = 0;

            for (int i = 0; i < SkladID.Count; i++)
            {

                if (ID < SkladID[i])
                    ID = SkladID[i];
            }
            string abc = textBox4.Text;
            int num = Convert.ToInt32(abc);
            dal.InsertSkaldBInBD(ID+1, dataGridView1.CurrentRow.Cells["Лекарственное средство"].Value.ToString(), abc, IDBOL);
            ArrayList AllBLek = dal.GetAllLekSkald(IDBOL);
            dataGridView2.DataSource = AllBLek;
            if (dataGridView2.RowCount > 0)
            {
                dataGridView2.Columns["ID"].Visible = false;
                dataGridView2.Columns["IDBol"].Visible = false;
            }*/
            List<long> SkladID = dal.GetSKLADID();
            long ID = 0;

            for (int i = 0; i < SkladID.Count; i++)
            {

                if (ID < SkladID[i])
                    ID = SkladID[i];
            }
            string abc = textBox4.Text;
            //int num = Convert.ToInt32(abc);
            dal.InsertSkaldBInBD(ID + 1, dataGridView1.CurrentRow.Cells["Лекарственное средство"].Value.ToString(), abc, IDBOL);
            ArrayList AllBLek = dal.GetAllLekSkald(IDBOL);
            dataGridView2.DataSource = AllBLek;
            if (dataGridView2.RowCount > 0)
            {
                dataGridView2.Columns["ID"].Visible = false;
                dataGridView2.Columns["IDBol"].Visible = false;
            }

        }
    }
}

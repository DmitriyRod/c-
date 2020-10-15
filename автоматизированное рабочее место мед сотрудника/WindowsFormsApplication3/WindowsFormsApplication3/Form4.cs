using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {
        DAL dal = new DAL();
        public Form4()
        {
            InitializeComponent();
            ArrayList allDoc = dal.GetAllDoc();
            dataGridView1.DataSource = allDoc; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dal.InsertDocBD(Convert.ToInt64(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList allDoc = dal.GetAllDocFam(textBox1.Text);
            dataGridView1.DataSource = allDoc;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Del"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList allDoc = dal.GetAllDocName(textBox1.Text);
            dataGridView1.DataSource = allDoc;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Del"].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList allDoc = dal.GetAllDocOtch(textBox1.Text);
            dataGridView1.DataSource = allDoc;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Del"].Visible = false;
        }
    }
}

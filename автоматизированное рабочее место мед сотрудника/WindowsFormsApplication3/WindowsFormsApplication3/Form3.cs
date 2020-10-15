using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        DAL dal = new DAL();
        public Form3()
        {
            InitializeComponent();
            //public bool InsertDoctorsInBD(long Doctors_ID, string Doc_Name, string Doc_Fam, string Doc_Otch, string Doctor_Pass, string Doc_Phone, string Spec)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<long> DoctorsID = dal.GetDoctorsID();
            long ID = 0;

            for (int i = 0; i < DoctorsID.Count; i++)
            {

                if (ID < DoctorsID[i])
                    ID = DoctorsID[i];
            }
            dal.InsertDoctorsInBD(ID + 1, textBox2.Text, textBox1.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox4.Text);
            this.Close();
        }

        
    }
}

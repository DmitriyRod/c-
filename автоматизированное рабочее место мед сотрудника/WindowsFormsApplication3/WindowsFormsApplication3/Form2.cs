using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        DAL dal = new DAL();
        public Form2()
        {
            InitializeComponent();
            List<Pacients> GetTime = dal.GetTimePac();
            List<Doctors> GetDoc = dal.GetDoctors();
            List<long> PriemPacients = dal.GetPriemPacients();

            for (int i = 0; i < GetDoc.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = GetDoc[i].DocName;
                //dataGridView2.Columns["Column1"] =GetDoc[i].DocName;
                dataGridView1.Rows[i].Cells[0].Value = GetDoc[i].IdD;
                dataGridView1.Columns["Column1"].Width = 200;
            }
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == dateTimePicker1.Value.Day.ToString())
                    {
                        string ID;
                        ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (ID == GetTime[j].IdD.ToString())
                        {
                            if (GetTime[j].Priem_Hour == "8")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[2].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column2"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[3].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column3"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "9")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[4].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column4"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[5].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column5"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "10")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[6].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column6"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[7].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column7"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "11")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[8].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column8"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[9].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column9"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "12")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[10].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column10"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[11].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column11"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "13")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[12].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column12"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[13].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column13"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "14")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[14].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column14"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[15].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column15"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "15")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[16].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column16"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[17].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column17"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "16")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[18].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column18"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[19].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column19"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "17")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[20].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column20"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[21].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column21"].Width = 200;
                                    }
                                }
                            }

                            if (GetTime[j].Priem_Hour == "18")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[22].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column22"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[23].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column23"].Width = 200;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dataGridView1.Columns["ID"].Visible = false;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Hide();
            Form3 newForm3 = new Form3();
            newForm3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Hide();
            Form4 newForm4 = new Form4();
            newForm4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Hide();
            Form5 newForm5 = new Form5();
            newForm5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Hide();
            Form6 newForm6 = new Form6();
            newForm6.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            List<Pacients> GetTime = dal.GetTimePac();
            List<Doctors> GetDoc = dal.GetDoctors();
            List<long> PriemPacients = dal.GetPriemPacients();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < GetDoc.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = GetDoc[i].DocName;
                //dataGridView2.Columns["Column1"] =GetDoc[i].DocName;
                dataGridView1.Rows[i].Cells[0].Value = GetDoc[i].IdD;
                dataGridView1.Columns["Column1"].Width = 200;
            }
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == dateTimePicker1.Value.Day.ToString())
                    {
                        string ID;
                        ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (ID == GetTime[j].IdD.ToString())
                        {
                            if (GetTime[j].Priem_Hour == "8")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[2].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column2"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[3].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column3"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "9")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[4].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column4"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[5].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column5"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "10")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[6].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column6"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[7].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column7"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "11")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[8].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column8"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[9].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column9"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "12")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[10].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column10"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[11].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column11"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "13")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[12].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column12"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[13].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column13"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "14")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[14].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column14"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[15].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column15"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "15")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[16].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column16"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[17].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column17"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "16")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[18].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column18"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[19].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column19"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "17")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[20].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column20"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[21].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column21"].Width = 200;
                                    }
                                }
                            }

                            if (GetTime[j].Priem_Hour == "18")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView1.Rows[i].Cells[22].Value = GetTime[j].PacName.ToString();
                                    dataGridView1.Columns["Column22"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView1.Rows[i].Cells[23].Value = GetTime[j].PacName.ToString();
                                        dataGridView1.Columns["Column23"].Width = 200;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 newForm7 = new Form7();
            newForm7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form8 newForm8 = new Form8();
            newForm8.ShowDialog();
        }
    }
}

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
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly string TemplateFileName = @"C:\Template\Медкарта.docx";
        DAL dal = new DAL();
        public Form1()
        {
            InitializeComponent();
            
            //ArrayList AllPriemPacients = dal.GetAllPriemPacients();
            //dataGridView2.DataSource = AllPriemPacients;
            dateTimePicker1.MinDate = DateTime.Today;
            List<Pacients> GetTime = dal.GetTimePac();
            List<Doctors> GetDoc = dal.GetDoctors();
            List<long> PriemPacients = dal.GetPriemPacients();

            for (int i = 0; i < GetDoc.Count; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[1].Value = GetDoc[i].DocName;
                dataGridView2.Rows[i].Cells[0].Value = GetDoc[i].IdD;
                dataGridView2.Columns["Column1"].Width = 200;
            }
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == dateTimePicker1.Value.Day.ToString())
                    {
                        string ID;
                        ID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        if (ID == GetTime[j].IdD.ToString())
                        {
                            if (GetTime[j].Priem_Hour == "8")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[2].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column2"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[3].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column3"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "9")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[4].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column4"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[5].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column5"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "10")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[6].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column6"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[7].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column7"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "11")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[8].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column8"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[9].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column9"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "12")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[10].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column10"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[11].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column11"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "13")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[12].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column12"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[13].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column13"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "14")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[14].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column14"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[15].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column15"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "15")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[16].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column16"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[17].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column17"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "16")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[18].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column18"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[19].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column19"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "17")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[20].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column20"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[21].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column21"].Width = 200;
                                    }
                                }
                            }

                            if (GetTime[j].Priem_Hour == "18")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[22].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column22"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[23].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column23"].Width = 200;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dataGridView2.Columns["ID"].Visible = false;
            //if(DateTime.Now.Day>=100)
            //ateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day+14);
        }

        private void вToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.ShowDialog();
        }

        private void назначитьВремяПациентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.ShowDialog();
        }

        private void добавитьНовогоПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.ShowDialog();
        }

        private void назначитьВремяПациентуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.ShowDialog();
            dateTimePicker1.MinDate = DateTime.Today;
            List<Pacients> GetTime = dal.GetTimePac();
            List<Doctors> GetDoc = dal.GetDoctors();
            List<long> PriemPacients = dal.GetPriemPacients();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < GetDoc.Count; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[1].Value = GetDoc[i].DocName;
                //dataGridView2.Columns["Column1"] =GetDoc[i].DocName;
                dataGridView2.Rows[i].Cells[0].Value = GetDoc[i].IdD;
                dataGridView2.Columns["Column1"].Width = 200;
            }
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == dateTimePicker1.Value.Day.ToString())
                    {
                        string ID;
                        ID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        if (ID == GetTime[j].IdD.ToString())
                        {
                            if (GetTime[j].Priem_Hour == "8")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[2].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column2"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[3].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column3"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "9")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[4].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column4"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[5].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column5"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "10")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[6].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column6"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[7].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column7"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "11")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[8].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column8"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[9].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column9"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "12")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[10].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column10"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[11].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column11"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "13")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[12].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column12"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[13].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column13"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "14")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[14].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column14"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[15].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column15"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "15")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[16].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column16"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[17].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column17"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "16")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[18].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column18"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[19].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column19"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "17")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[20].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column20"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[21].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column21"].Width = 200;
                                    }
                                }
                            }

                            if (GetTime[j].Priem_Hour == "18")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[22].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column22"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[23].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column23"].Width = 200;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dataGridView2.Columns["ID"].Visible = false;
            //this.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            List<Pacients> GetTime = dal.GetTimePac();
            List<Doctors> GetDoc = dal.GetDoctors();
            List<long> PriemPacients = dal.GetPriemPacients();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < GetDoc.Count; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[1].Value = GetDoc[i].DocName;
                //dataGridView2.Columns["Column1"] =GetDoc[i].DocName;
                dataGridView2.Rows[i].Cells[0].Value = GetDoc[i].IdD;
                dataGridView2.Columns["Column1"].Width = 200;
            }
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == dateTimePicker1.Value.Day.ToString())
                    {
                        string ID;
                        ID = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        if (ID == GetTime[j].IdD.ToString())
                        {
                            if (GetTime[j].Priem_Hour == "8")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[2].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column2"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[3].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column3"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "9")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[4].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column4"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[5].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column5"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "10")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[6].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column6"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[7].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column7"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "11")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[8].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column8"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[9].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column9"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "12")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[10].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column10"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[11].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column11"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "13")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[12].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column12"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[13].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column13"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "14")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[14].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column14"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[15].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column15"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "15")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[16].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column16"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[17].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column17"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "16")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[18].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column18"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[19].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column19"].Width = 200;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "17")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[20].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column20"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[21].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column21"].Width = 200;
                                    }
                                }
                            }

                            if (GetTime[j].Priem_Hour == "18")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[22].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column22"].Width = 200;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[23].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column23"].Width = 200;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            dataGridView2.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {   //fam
            ArrayList allPacients = dal.GetAllPacientsFam(textBox4.Text);
            dataGridView1.DataSource = allPacients;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList allPacients = dal.GetAllPacientsName(textBox3.Text);
            dataGridView1.DataSource = allPacients;
            //nam
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList allPacients = dal.GetAllPacientsOtch(textBox1.Text);
            dataGridView1.DataSource = allPacients;
            //otch
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tel
            ArrayList allPacients = dal.GetAllPacientsTel(textBox2.Text);
            dataGridView1.DataSource = allPacients;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //snils
            ArrayList allPacients = dal.GetAllPacientsSnils(textBox9.Text);
            dataGridView1.DataSource = allPacients;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //polis
            ArrayList allPacients = dal.GetAllPacientsPolis(textBox10.Text);
            dataGridView1.DataSource = allPacients;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fio,age = "",Bday,Bmonth,Byear,address,prof;
            fio = dataGridView1.CurrentRow.Cells["Фамилия"].Value.ToString();
            fio +=" "+ dataGridView1.CurrentRow.Cells["Имя"].Value.ToString();
            fio += " " + dataGridView1.CurrentRow.Cells["Отчество"].Value.ToString();
            Bday =dataGridView1.CurrentRow.Cells["День"].Value.ToString();
            Bmonth =dataGridView1.CurrentRow.Cells["Месяц"].Value.ToString();
            Byear =dataGridView1.CurrentRow.Cells["Год"].Value.ToString();
            address= dataGridView1.CurrentRow.Cells["Адрес"].Value.ToString();
            prof = dataGridView1.CurrentRow.Cells["Профессия"].Value.ToString();
            int yearNow,monthNow,dayNow,dayLate;
            yearNow = System.DateTime.Now.Year;
            monthNow = System.DateTime.Now.Month;
            dayNow= System.DateTime.Now.Day;
            if (Bmonth == "Январь")
            {
                if (monthNow>=1)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }

            }
            if (Bmonth == "Февраль")
            {
                if (monthNow >= 2)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Март")
            {
                if (monthNow >= 3)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Апрель")
            {
                if (monthNow >= 4)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Май")
            {
                if (monthNow >= 5)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Июнь")
            {
                if (monthNow >= 6)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Июль")
            {
                if (monthNow >= 7)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Август")
            {
                if (monthNow >= 8)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Сентябрь")
            {
                if (monthNow >= 9)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Октябрь")
            {
                if (monthNow >= 10)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }

            }
            if (Bmonth == "Ноябрь")
            {
                if (monthNow >= 11)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            if (Bmonth == "Декабрь")
            {
                if (monthNow >= 12)
                {
                    if (dayNow >= Convert.ToInt32(Bday))
                    {
                        age = (yearNow - Convert.ToInt32(Byear)).ToString();
                    }
                    else
                    {
                        age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                    }
                }
                else
                {
                    age = (yearNow - Convert.ToInt32(Byear) - 1).ToString();
                }
            }
            try
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{fio}", fio, wordDocument);
                ReplaceWordStub("{age}", age, wordDocument);
                ReplaceWordStub("{address}", address, wordDocument);
                ReplaceWordStub("{prof}", prof, wordDocument);
                ReplaceWordStub("{card}", dataGridView1.CurrentRow.Cells["Номер карты"].Value.ToString() , wordDocument);
                ReplaceWordStub("{day}", System.DateTime.Now.Day.ToString(), wordDocument);
                ReplaceWordStub("{year}", (System.DateTime.Now.Year%100).ToString(), wordDocument);
                if (monthNow  == 1)
                {
                    ReplaceWordStub("{month}", "Январь", wordDocument);
                }
                if (monthNow == 2)
                {
                    ReplaceWordStub("{month}", "Февраль", wordDocument); 
                }
                if (monthNow == 3)
                {
                    ReplaceWordStub("{month}", "Март", wordDocument);
                }
                if (monthNow == 4)
                {
                    ReplaceWordStub("{month}", "Апрель", wordDocument);
                }
                if (monthNow == 5)
                {
                    ReplaceWordStub("{month}", "Май", wordDocument);
                }
                if (monthNow == 6)
                {
                    ReplaceWordStub("{month}", "Июнь", wordDocument);
                }
                if (monthNow == 7)
                {
                    ReplaceWordStub("{month}", "Июль", wordDocument);
                }
                if (monthNow == 8)
                {
                    ReplaceWordStub("{month}", "Август", wordDocument);
                }
                if (monthNow == 9)
                {
                    ReplaceWordStub("{month}", "Сентябрь", wordDocument);
                }
                if (monthNow == 10)
                {
                    ReplaceWordStub("{month}", "Октябрь", wordDocument);
                }
                if (monthNow == 11)
                {
                    ReplaceWordStub("{month}", "Ноябрь", wordDocument);
                }
                if (monthNow == 12)
                {
                    ReplaceWordStub("{month}", "Декабрь", wordDocument);
                }
                    wordDocument.SaveAs(@"C:\Result\" + fio + ".doc");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
           
            dataGridView1.DataSource = "";
        }

        private void ReplaceWordStub(string stubToReplace,string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}

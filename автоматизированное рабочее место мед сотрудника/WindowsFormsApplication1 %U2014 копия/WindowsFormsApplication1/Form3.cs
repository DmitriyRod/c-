﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Word=Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        DAL dal = new DAL();
        long idDoc;
        List<Pacients> GetTime;
        List<Doctors> GetDoc;
        public Form3(long idDocNew)
        {
            
            idDoc = idDocNew;
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
            ArrayList allPacients = dal.GetAllPacients();
            dataGridView1.DataSource = allPacients;
            GetTime = dal.GetTimePac();
            List<long> PriemPacients = dal.GetPriemPacients();
            GetDoc = dal.GetDoctors();
            for (int i = 0; i < GetDoc.Count; i++)
            {
                if (idDoc == GetDoc[i].IdD)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[1].Value = GetDoc[i].DocName;
                    dataGridView2.Rows[i].Cells[0].Value = GetDoc[i].IdD;
                    dataGridView2.Columns["Column1"].Width = 200;
                }

            }
            dataGridView2.Columns["ID"].Visible = false;
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == DateTime.Now.Day.ToString())
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
                                    dataGridView2.Rows[i].Cells[2].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[3].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column3"].Width = 200;
                                        dataGridView2.Rows[i].Cells[3].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "9")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[4].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column4"].Width = 200;
                                    dataGridView2.Rows[i].Cells[4].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[5].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column5"].Width = 200;
                                        dataGridView2.Rows[i].Cells[5].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "10")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[6].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column6"].Width = 200;
                                    dataGridView2.Rows[i].Cells[6].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[7].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column7"].Width = 200;
                                        dataGridView2.Rows[i].Cells[7].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "11")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[8].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column8"].Width = 200;
                                    dataGridView2.Rows[i].Cells[8].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[9].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column9"].Width = 200;
                                        dataGridView2.Rows[i].Cells[9].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "12")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[10].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column10"].Width = 200;
                                    dataGridView2.Rows[i].Cells[10].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[11].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column11"].Width = 200;
                                        dataGridView2.Rows[i].Cells[11].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "13")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[12].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column12"].Width = 200;
                                    dataGridView2.Rows[i].Cells[12].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[13].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column13"].Width = 200;
                                        dataGridView2.Rows[i].Cells[13].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "14")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[14].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column14"].Width = 200;
                                    dataGridView2.Rows[i].Cells[14].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[15].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column15"].Width = 200;
                                        dataGridView2.Rows[i].Cells[15].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "15")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[16].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column16"].Width = 200;
                                    dataGridView2.Rows[i].Cells[16].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[17].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column17"].Width = 200;
                                        dataGridView2.Rows[i].Cells[17].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "16")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[18].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column18"].Width = 200;
                                    dataGridView2.Rows[i].Cells[18].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[19].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column19"].Width = 200;
                                        dataGridView2.Rows[i].Cells[19].ReadOnly = true;
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "17")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[20].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column20"].Width = 200;
                                    dataGridView2.Rows[i].Cells[20].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[21].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column21"].Width = 200;
                                        dataGridView2.Rows[i].Cells[21].ReadOnly = true;
                                    }
                                }
                            }

                            if (GetTime[j].Priem_Hour == "18")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    dataGridView2.Rows[i].Cells[22].Value = GetTime[j].PacName.ToString();
                                    dataGridView2.Columns["Column22"].Width = 200;
                                    dataGridView2.Rows[i].Cells[22].ReadOnly = true;
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        dataGridView2.Rows[i].Cells[23].Value = GetTime[j].PacName.ToString();
                                        dataGridView2.Columns["Column23"].Width = 200;
                                        dataGridView2.Rows[i].Cells[23].ReadOnly = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fam
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
            List<long> PriemPacients = dal.GetPriemPacientsBD();
            long ID = 0;

            for (int i = 0; i < PriemPacients.Count; i++)
            {

                if (ID < PriemPacients[i])
                    ID = PriemPacients[i];
            }
            int X = 0;
            X = dataGridView2.CurrentCellAddress.X;
            int Y = 0;
            Y = dataGridView2.CurrentCellAddress.Y;
            if (dataGridView2.Rows[Y].Cells[X].ReadOnly == false)
            {
                dataGridView2.Rows[Y].Cells[X].Value = X.ToString() + Y.ToString();
                int Priem_hour = 0;
                string Priem_min = "";
                string Priem_hour1 = "";
                for (int i = 2; i < 24; i++)
                {
                    if (X == i)
                    {
                        if (i % 2 == 0)
                        {
                            Priem_hour = 7 + i / 2;
                            Priem_hour1 = Priem_hour.ToString();
                            Priem_min = "00";
                            break;
                        }
                        else
                        {
                            Priem_hour = 7 + i / 2;
                            Priem_hour1 = Priem_hour.ToString();
                            Priem_min = "30";
                            break;
                        }
                    }
                }
                dal.InsertPacientInPriem(ID + 1, Convert.ToInt32(dataGridView1.CurrentRow.Cells["Номер карты"].Value.ToString()), Priem_hour1, Priem_min, Convert.ToInt32(dataGridView2.Rows[Y].Cells[0].Value.ToString()), dateTimePicker1.Value.Day.ToString(), dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString());
                //Form1 newForm3 = new Form1();
                //newForm3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка! Выберите свободную дату!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<GetAllPrint> AllPrint = dal.AllForPrint(idDoc);
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add(Visible: true);
            Word.Range r = doc.Range();
            int kolstr = 0;
            for(int i=0;i<AllPrint.Count;i++)
            {
                
                if( Convert.ToInt64(AllPrint[i].Year) >= Convert.ToInt64(dateTimePicker3.Value.Year) && Convert.ToInt64(AllPrint[i].Year) <= Convert.ToInt64(dateTimePicker2.Value.Year))
                {
                    if( Convert.ToInt64(AllPrint[i].Month) >= dateTimePicker3.Value.Month && Convert.ToInt64(AllPrint[i].Month) <= dateTimePicker2.Value.Month)
                    {
                        if (  Convert.ToInt64(AllPrint[i].Day) >= dateTimePicker3.Value.Day && Convert.ToInt64(AllPrint[i].Day) <= dateTimePicker2.Value.Day)
                        {
                            kolstr++;
                        }
                    }
                }
            }
            Word.Table t = doc.Tables.Add(r, kolstr, 5);
            t.Borders.Enable = 1;
            int ii = 1;
            int flag = 0, iii = 0;
            foreach (Word.Row row in t.Rows)
            {
                foreach (Word.Cell cell in row.Cells)
                {
                    if (cell.RowIndex == 1)
                    {
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Range.Text = "ФИО Врача";
                            ii = 1;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Range.Text = "ФИО Пациента";
                            ii = 2;
                        }

                        if (cell.ColumnIndex == 3)
                        {
                            cell.Range.Text = "Дата посещения";
                            ii = 4;
                        }
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Range.Text = "Диагноз";
                            ii = 5;
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Range.Text = "Код";
                            ii = 6;
                        }

                        // cell.Range.Text = "Колонка" + cell.ColumnIndex.ToString();
                        cell.Range.Bold = 1;
                        cell.Range.Font.Name = "verdana";
                        cell.Range.Font.Size = 10;

                        cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else
                    {
                        if (flag==0)
                        {
                            while( iii < AllPrint.Count )
                            {

                                if (Convert.ToInt64(AllPrint[iii].Year) >= Convert.ToInt64(dateTimePicker3.Value.Year) && Convert.ToInt64(AllPrint[iii].Year) <= Convert.ToInt64(dateTimePicker2.Value.Year))
                                {
                                    if (Convert.ToInt64(AllPrint[iii].Month) >= dateTimePicker3.Value.Month && Convert.ToInt64(AllPrint[iii].Month) <= dateTimePicker2.Value.Month)
                                    {
                                        if (Convert.ToInt64(AllPrint[iii].Day) >= dateTimePicker3.Value.Day && Convert.ToInt64(AllPrint[iii].Day) <= dateTimePicker2.Value.Day)
                                        {
                                            flag++;
                                           
                                            break;
                                        }
                                    }
                                }
                                iii++;
                            }
                        }
                        
                        if (cell.ColumnIndex == 1)
                        {
                            cell.Range.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Range.Text = AllPrint[iii].PacName;
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Range.Text = AllPrint[iii].Day.ToString() + "/" + AllPrint[iii].Month.ToString() + "/" + AllPrint[iii].Year.ToString();
                        }

                        if (cell.ColumnIndex == 4)
                        {
                            cell.Range.Text = AllPrint[iii].Diagnoz.ToString();
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            cell.Range.Text = AllPrint[iii].Code;
                            flag = 0;
                        }

                    }
                }
            }
           doc.SaveAs(@"C:\Result\" + "Для статиста " + dataGridView2.Rows[0].Cells[1].Value.ToString() + " с " + dateTimePicker3.Value.Year.ToString()+ "по " + dateTimePicker2.Value.Year.ToString()+ "с " + dateTimePicker3.Value.Month.ToString() + "по " + dateTimePicker2.Value.Month.ToString() + "с " + dateTimePicker3.Value.Day.ToString() +"по "+ dateTimePicker2.Value.Day.ToString()  + ".doc");
           doc.Close();
            app.Documents.Open(@"C:\Template\1.docx");
            try
            {
                app.Documents.Close();
                app.Quit();
            }
            catch
            {

            }




        }
    }
}

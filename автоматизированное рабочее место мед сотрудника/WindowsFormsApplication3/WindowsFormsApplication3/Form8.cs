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

namespace WindowsFormsApplication3
{
    public partial class Form8 : Form
    {
        DAL dal = new DAL();
        public Form8()
        {
            InitializeComponent();
            ArrayList allPacients = dal.GetAllPacients();
            dataGridView1.DataSource = allPacients;
            //dataGridView1.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fam
            ArrayList allPacients = dal.GetAllPacientsFam(textBox4.Text);
            dataGridView1.DataSource = allPacients;
           // dataGridView1.Columns["ID"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList allPacients = dal.GetAllPacientsName(textBox3.Text);
            dataGridView1.DataSource = allPacients;
            //dataGridView1.Columns["ID"].Visible = false;
            //nam
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList allPacients = dal.GetAllPacientsOtch(textBox1.Text);
            dataGridView1.DataSource = allPacients;
            //dataGridView1.Columns["ID"].Visible = false;
            //otch
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tel
            ArrayList allPacients = dal.GetAllPacientsTel(textBox2.Text);
            dataGridView1.DataSource = allPacients;
            //dataGridView1.Columns["ID"].Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //snils
            ArrayList allPacients = dal.GetAllPacientsSnils(textBox9.Text);
            dataGridView1.DataSource = allPacients;
            //dataGridView1.Columns["ID"].Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //polis
            ArrayList allPacients = dal.GetAllPacientsPolis(textBox10.Text);
            dataGridView1.DataSource = allPacients;
            //dataGridView1.Columns["ID"].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            List<Shablons> GetTime = dal.GetAllShablons(Convert.ToInt64(dataGridView1.CurrentRow.Cells["Номер карты"].Value.ToString()));
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add(Visible: true);
            Word.Range r = doc.Range();
            Word.Table t = doc.Tables.Add(r, GetTime.Count, 1);
            t.Borders.Enable = 1;
            int ii = -1;
           // int flag = 0, iii = 0;
            foreach (Word.Row row in t.Rows)
            {
                foreach (Word.Cell cell in row.Cells)
                {
                    ii++;
                    /*if (cell.RowIndex == 1)
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
                        if (flag == 0)
                        {
                            while (iii < AllPrint.Count)
                            {

                                if (Convert.ToInt64(AllPrint[iii].Year) >= Convert.ToInt64(dateTimePicker3.Value.Year) && Convert.ToInt64(AllPrint[iii].Year) <= Convert.ToInt64(dateTimePicker2.Value.Year))
                                {
                                    if (Convert.ToInt64(AllPrint[iii].Month) >= dateTimePicker3.Value.Month && Convert.ToInt64(AllPrint[iii].Month) <= dateTimePicker2.Value.Month)
                                    {
                                        if (Convert.ToInt64(AllPrint[iii].Day) >= dateTimePicker3.Value.Day && Convert.ToInt64(AllPrint[iii].Day) <= dateTimePicker2.Value.Day)
                                        {
                                            flag++;
                                            iii++;
                                            break;
                                        }
                                    }
                                }
                            }
                        }*/

                       // if (cell.ColumnIndex == 1)
                       // {
                            cell.Range.Text = "ФИО врача: "+GetTime[ii].DocName+"\n"+"Дата: "+GetTime[ii].Day+"/"+GetTime[ii].Month+"/"+GetTime[ii].Year+"\n" +GetTime[ii].Bolezn+"\n" + GetTime[ii].Shablon;
                       /* }
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
                        }*/

                    //}
                }
            }
            doc.SaveAs(@"C:\Result\" + dataGridView1.CurrentRow.Cells["Фамилия"].Value.ToString() + ".doc");

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

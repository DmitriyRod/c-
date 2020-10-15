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
using Novacode;
using System.Drawing.Imaging;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private readonly string TemplateFileName = @"C:\Template\ШаблонЗаболеваний.docx";
        DAL dal = new DAL();
        long idDoc, idPac,priemID;
        string fiopac;
        List<Pacients> GetTime;
        List<Doctors> GetDoc;
        public Form2(string Login,string Password)
        {
            InitializeComponent();

            GetTime = dal.GetTimePac();
            idDoc = dal.GetDoctorsIDBD(Login, Password);
            List<long> PriemPacients = dal.GetPriemPacients();
            GetDoc = dal.GetDoctors();
            for (int i = 0; i < GetDoc.Count; i++)
            {
                if(idDoc == GetDoc[i].IdD)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[1].Value = GetDoc[i].DocName;
                    dataGridView1.Rows[i].Cells[0].Value = GetDoc[i].IdD;
                    textBox16.Text= GetDoc[i].DocName;
                    dataGridView1.Columns["Column1"].Width = 200;
                }
                
            }
            
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == DateTime.Now.Day.ToString())
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
           // dataGridView1.DataSource = PriemPacients;
            SettingsDGV_Pacients(); //скрывание колонок.
            textBox6.Text = System.DateTime.Now.ToString();

        }


        void SettingsDGV_Pacients()
    {
        try
        {
            dataGridView1.Columns["Pacient_ID"].Visible = false;
            dataGridView1.Columns["День"].Visible = false;
            dataGridView1.Columns["Месяц"].Visible = false;
            dataGridView1.Columns["Год"].Visible = false;
            dataGridView1.Columns["Адрес проживания"].Visible = false;
            //dataGridView1.Columns["Адрес работы"].Visible = false;
            dataGridView1.Columns["Профессия"].Visible = false;

            }
        catch
        {

        }

    }
    private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 newForm1 = new Form1();
            newForm1.ShowDialog();
            this.Close();
        }

       
        
        private void pictureBoxTgt_MouseClick(object sender, MouseEventArgs e)
        {
            Point sPt = scaledPoint(pictureBoxTgt, e.Location);
            Bitmap bmp = (Bitmap)pictureBoxTgt.Image;
            Color c0 = bmp.GetPixel(sPt.X, sPt.Y);
            if (colorDialog1.Color == Color.Black || colorDialog1.Color == Color.White)
            {
                colorDialog1.Color = Color.Red;
            }
            if (c0.A == Color.Black.A && c0.B == Color.Black.B && c0.G == Color.Black.G && c0.R == Color.Black.R)
                return;
            if (c0.A != 255 || c0.B != 255 || c0.G !=255 || c0.R != 255)
                colorDialog1.Color = Color.White;
           
            
            Fill4(bmp, sPt, c0,colorDialog1.Color);
            pictureBoxTgt.Image = bmp;
        }
        static void Fill4(Bitmap bmp, Point pt, Color c0, Color c1)
        {
            Color cx = bmp.GetPixel(pt.X, pt.Y);
            
            
           // if (cx.GetBrightness() < 0.01f) return;  // optional, to prevent filling a black grid
            Rectangle bmpRect = new Rectangle(Point.Empty, bmp.Size);
            Stack<Point> stack = new Stack<Point>();
            int x0 = pt.X;
            int y0 = pt.Y;

            stack.Push(new Point(x0, y0));
            while (stack.Any())
            {
                Point p = stack.Pop();
                if (!bmpRect.Contains(p)) continue;
                cx = bmp.GetPixel(p.X, p.Y);
                if (cx == c0)
                {
                    bmp.SetPixel(p.X, p.Y, c1);
                    stack.Push(new Point(p.X, p.Y + 1));
                    stack.Push(new Point(p.X, p.Y - 1));
                    stack.Push(new Point(p.X + 1, p.Y));
                    stack.Push(new Point(p.X - 1, p.Y));
                }
            }
        }
        static Point scaledPoint(PictureBox pb, Point pt)
        {
            float scaleX = 1f * pb.Image.Width / pb.ClientSize.Width;
            float scaleY = 1f * pb.Image.Height / pb.ClientSize.Height;
            Point sPt = new Point((int)(pt.X * scaleX), (int)(pt.Y * scaleY));
            return new Point(sPt.X, sPt.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
        }

        private void pictureBoxTgt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int X = dataGridView1.CurrentCellAddress.X;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < GetTime.Count; j++)
                {
                    if (GetTime[j].Priem_Day == DateTime.Now.Day.ToString())
                    {
                        string ID;
                        ID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (ID == GetTime[j].IdD.ToString())
                        {
                            if (GetTime[j].Priem_Hour == "8")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[2].Value = GetTime[j].PacName.ToString();
                                   // dataGridView1.Columns["Column2"].Width = 200;
                                    if(X==2)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[3].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column3"].Width = 200;
                                        if (X == 3)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "9")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[4].Value = GetTime[j].PacName.ToString();
                                   // dataGridView1.Columns["Column4"].Width = 200;
                                    if (X == 4)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[5].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column5"].Width = 200;
                                        if (X == 5)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "10")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[6].Value = GetTime[j].PacName.ToString();
                                    //dataGridView1.Columns["Column6"].Width = 200;
                                    if (X == 6)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[7].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column7"].Width = 200;
                                        if (X == 7)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "11")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[8].Value = GetTime[j].PacName.ToString();
                                    //dataGridView1.Columns["Column8"].Width = 200;
                                    if (X == 8)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[9].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column9"].Width = 200;
                                        if (X == 9)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "12")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[10].Value = GetTime[j].PacName.ToString();
                                    //dataGridView1.Columns["Column10"].Width = 200;
                                    if (X == 10)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                   
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                       // dataGridView1.Rows[i].Cells[11].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column11"].Width = 200;
                                        if (X == 11)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "13")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[12].Value = GetTime[j].PacName.ToString();
                                    //dataGridView1.Columns["Column12"].Width = 200;
                                    if (X == 12)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[13].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column13"].Width = 200;
                                        if (X == 13)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "14")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[14].Value = GetTime[j].PacName.ToString();
                                   // dataGridView1.Columns["Column14"].Width = 200;
                                    if (X == 14)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[15].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column15"].Width = 200;
                                        if (X == 15)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "15")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[16].Value = GetTime[j].PacName.ToString();
                                    //dataGridView1.Columns["Column16"].Width = 200;
                                    if (X == 16)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                       // dataGridView1.Rows[i].Cells[17].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column17"].Width = 200;
                                        if (X == 17)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "16")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[18].Value = GetTime[j].PacName.ToString();
                                    //dataGridView1.Columns["Column18"].Width = 200;
                                    if (X == 18)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[19].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column19"].Width = 200;
                                        if (X == 19)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (GetTime[j].Priem_Hour == "17")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                    //dataGridView1.Rows[i].Cells[20].Value = GetTime[j].PacName.ToString();
                                    //dataGridView1.Columns["Column20"].Width = 200;
                                    if (X == 20)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                       // dataGridView1.Rows[i].Cells[21].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column21"].Width = 200;
                                        if (X == 21)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }

                            if (GetTime[j].Priem_Hour == "18")
                            {
                                if (GetTime[j].Priem_Min == "00")
                                {
                                   // dataGridView1.Rows[i].Cells[22].Value = GetTime[j].PacName.ToString();
                                   // dataGridView1.Columns["Column22"].Width = 200;
                                    if (X == 22)
                                    {
                                        idPac = GetTime[j].IdP;
                                        priemID = GetTime[j].IDpriem;
                                        fiopac = GetTime[j].PacName;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (GetTime[j].Priem_Min == "30")
                                    {
                                        //dataGridView1.Rows[i].Cells[23].Value = GetTime[j].PacName.ToString();
                                        //dataGridView1.Columns["Column23"].Width = 200;
                                        if (X == 23)
                                        {
                                            idPac = GetTime[j].IdP;
                                            priemID = GetTime[j].IDpriem;
                                            fiopac = GetTime[j].PacName;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //dataGridView1.Columns["ID"].Visible = false;
            List<PacientsBd> GetInf= dal.GetInfoPac(idPac);
            textBox8.Text = GetInf[0].IdP.ToString();
            textBox1.Text = GetInf[0].PacName;
            textBox2.Text = GetInf[0].Phone;
            textBox3.Text = GetInf[0].Address;
            textBox4.Text = GetInf[0].Snils;
            textBox7.Text = GetInf[0].NumPolis;
            
            dataGridView2.DataSource = dal.GetAllDiagnoz(GetInf[0].IdP); //Diagnoz priema
            /*ArrayList allBolezni = dal.GetAllBol();
            dataGridView3.DataSource = allBolezni;
            dataGridView3.Columns["ID"].Visible = false;
            dataGridView3.Columns["Шаблон"].Visible = false;*/
            dataGridView3.Rows.Clear();
            List<Bolezni> GetBol = dal.GetInfoBol();
            for (int i = 0; i < GetBol.Count; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Cells[0].Value = GetBol[i].IdB;
                dataGridView3.Rows[i].Cells[1].Value = GetBol[i].BolezniName;
               string str= GetBol[i].Code;
                str=str.Replace('\n', ' ');
                dataGridView3.Rows[i].Cells[2].Value = str;
                dataGridView3.Rows[i].Cells[3].Value = GetBol[i].Templ;
                // textBox16.Text = GetDoc[i].DocName;
                // dataGridView1.Columns["Column1"].Width = 200;

            }
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[3].Visible = false;
            //dataGridView4.DataSource = dal.GetAllLekarstva(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[11].Value.ToString());
            //dataGridView5.DataSource = dal.GetAllUslugi(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[11].Value.ToString());
        }

        private void pictureBoxTgt_DoubleClick(object sender,MouseEventArgs e)
        {
            /*Point sPt = scaledPoint(pictureBoxTgt, e.Location);
            Bitmap bmp = (Bitmap)pictureBoxTgt.Image;
            Color c0 = bmp.GetPixel(sPt.X, sPt.Y);
            if (colorDialog1.Color == Color.Black)
            {
                colorDialog1.Color = Color.White;
            }

            Fill4(bmp, sPt, c0, Color.White);
            pictureBoxTgt.Image = bmp;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            List<Bolezni> GetBol=dal.GetInfoBol();
            for (int i = 0; i < GetBol.Count; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Cells[0].Value = GetBol[i].IdB;
                dataGridView3.Rows[i].Cells[1].Value = GetBol[i].BolezniName;
                string str = GetBol[i].Code;
                str = str.Replace('\n', ' ');
                dataGridView3.Rows[i].Cells[2].Value = str;
                dataGridView3.Rows[i].Cells[3].Value = GetBol[i].Templ;

            }
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[3].Visible = false;
            for (int i=0;i<dataGridView3.RowCount-1;i++)
            {
                string abc = dataGridView3.Rows[i].Cells[1].Value.ToString();
                bool b = dataGridView3.Rows[i].Cells[1].Value.ToString().Contains(textBox5.Text);
                if (!b)
                {
                    dataGridView3.Rows.RemoveAt(i);
                    i = -1;
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<long> DiagnozPacients = dal.GetDiagnozPacients();
            long ID = 0;

            for (int i = 0; i < DiagnozPacients.Count; i++)
            {

                if (ID < DiagnozPacients[i])
                    ID = DiagnozPacients[i];
            }
            string dy = DateTime.Now.Year.ToString();
            string dm = DateTime.Now.Month.ToString();
            string dd = DateTime.Now.Day.ToString();
            bool f = dal.InsertPacientInDiagnoz(Convert.ToInt64(dataGridView3.CurrentRow.Cells[0].Value.ToString()), dy, priemID, ID + 1, idPac, dm, dd, idDoc);
            try
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{ILL}", dataGridView3.CurrentRow.Cells[3].Value.ToString(), wordDocument);
                //ReplaceWordStub("{Image}", pictureBoxTgt.Image.ToString(), wordDocument);
                wordDocument.SaveAs(@"C:\Result\" + textBox1.Text + ".doc");
                //pictureBoxTgt.Image.Save(@"C:\Result\1.doc", System.Drawing.Imaging.ImageFormat.Png);
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<long> DiagnozPacients = dal.GetDiagnozPacients();
            long ID = 0;

            for (int i = 0; i < DiagnozPacients.Count; i++)
            {

                if (ID < DiagnozPacients[i])
                    ID = DiagnozPacients[i];
            }
            string dy = DateTime.Now.Year.ToString();
            string dm = DateTime.Now.Month.ToString();
            string dd = DateTime.Now.Day.ToString();
            bool f = dal.InsertPacientInDiagnoz(Convert.ToInt64(dataGridView3.CurrentRow.Cells[0].Value.ToString()),dy , priemID, ID +1, idPac, dm, dd, idDoc);
            List<LEk> AllSklad = dal.GetSklad();
            List<LEkMinus> minusSklad = dal.GetBolSklad(Convert.ToInt64(dataGridView3.CurrentRow.Cells[0].Value.ToString()));
            for(int i=0;i<minusSklad.Count;i++)
            {
                for(int j=0;j<AllSklad.Count;j++)
                {
                    if(minusSklad[i].Name_Lek==AllSklad[j].Lekarstvo)
                    {
                        Double per1 = Convert.ToDouble(minusSklad[i].Kol_Lek);
                        Double per2 = Convert.ToDouble(AllSklad[j].Kol_Lek);
                        Double per3 = per2 - per1;
                        if (per3<0)
                        {
                            per3 = 0;
                        }
                        dal.UpdateLek(AllSklad[j].Lek_ID, AllSklad[j].Lekarstvo, per3.ToString());
                    }
                }
            }
            int ALLDONE = 0;
            var wordApp = new Word.Application();
            wordApp.Visible = false;
            try
            {
                
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{ILL}", dataGridView3.CurrentRow.Cells[3].Value.ToString(), wordDocument);
                
               // wordDocument.SaveAs(@"C:\Result\" + textBox16.Text + " " + fiopac + " " + DateTime.Now.Year.ToString() + " " + DateTime.Now.Month.ToString() + " " + DateTime.Now.Day.ToString() + ".doc");
               
                // wordApp.Visible = true;
                pictureBoxTgt.Image.Save(@"C:\Template\1.jpg", ImageFormat.Jpeg);

                string fileName = @"C:\Template\1.jpg";//"c://msdn.bmp";  //the picture file to be inserted
                Object oMissed = wordDocument.Paragraphs[1].Range; //the position you want to insert
                Object oLinkToFile = false;  //default
                Object oSaveWithDocument = true;//default
                wordDocument.InlineShapes.AddPicture(fileName, ref oLinkToFile, ref oSaveWithDocument, ref oMissed);
                wordDocument.SaveAs(@"C:\Result\" + "Шаблон заболевания" + " " + textBox16.Text + " " + fiopac + " " + DateTime.Now.Day.ToString() + " " + DateTime.Now.Month.ToString() + " " + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + " " + DateTime.Now.Minute.ToString() + ".doc");
                wordDocument.Close();
                ALLDONE++;
                //pictureBoxTgt.Image.Save(@"C:\Result\" + textBox1.Text + ".doc",System.Drawing.Imaging.ImageFormat.Gif);
                // Bitmap bmpSave = (Bitmap)pictureBoxTgt.Image;
                // bmpSave.Save("C:\\Result\button.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!");
            }
            finally
            {
                wordApp.Quit();
            }
            File.Delete(@"C:\Template\1.jpg");
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add(Visible: true);
            Word.Range r = doc.Range();
            Word.Table t = doc.Tables.Add(r, 2, 5);
            t.Borders.Enable = 1;
            int ii = 1;
            foreach (Word.Row row in t.Rows)
            {
                foreach (Word.Cell cell in row.Cells)
                {
                    if (cell.RowIndex == 1)
                    {
                        if(cell.ColumnIndex==1)
                        {
                            cell.Range.Text = "ФИО Врача" ;
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
                        if(cell.ColumnIndex == 1)
                        {
                            cell.Range.Text = textBox16.Text ;
                        }
                        if (cell.ColumnIndex == 2)
                        {
                            cell.Range.Text = fiopac;
                        }
                        if (cell.ColumnIndex == 3)
                        {
                            cell.Range.Text = DateTime.Now.Day.ToString()+" "+ DateTime.Now.Month.ToString()+ " " + DateTime.Now.Year.ToString();
                        }
                        
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Range.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                        }
                        if (cell.ColumnIndex == 5)
                        {
                            string str = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                            str=str.Replace(' ', '\n');
                            cell.Range.Text = str;
                            ALLDONE++;
                        }

                    }
                }
            }
            /* string fileName = @"C:\Template\1.jpg";//"c://msdn.bmp";  //the picture file to be inserted
             Object oMissed = doc.Paragraphs[1].Range; //the position you want to insert
             Object oLinkToFile = false;  //default
             Object oSaveWithDocument = true;//default
             doc.InlineShapes.AddPicture(fileName, ref oLinkToFile, ref oSaveWithDocument, ref oMissed);*/
            doc.SaveAs(@"C:\Result\"+"Для статиста" + textBox16.Text+ " " + fiopac+ " " + DateTime.Now.Day.ToString() + " " + DateTime.Now.Month.ToString() + " " + DateTime.Now.Year.ToString()+" "+DateTime.Now.Hour.ToString()+" "+DateTime.Now.Minute.ToString() + ".doc");
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
           
            if(ALLDONE>=2)
            {
                MessageBox.Show("Файлы созданы");
            }

        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void врачебныйМодульToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3(idDoc);
            newForm3.ShowDialog();
        }
    }



}

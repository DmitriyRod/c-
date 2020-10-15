using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace WindowsFormsApplication1
{

    public class Pacients
    {
        public Pacients(long idP, long idD, string filename, string min, string hour, string day, string month, string year,long idpriem)
        {
            IdP = idP;
            IdD = idD;
            PacName = filename;
            Priem_Min = min;
            Priem_Hour = hour;
            Priem_Day = day;
            Priem_Month = month;
            Priem_Year = year;
            IDpriem = idpriem;
        }
        public long IdP { get; private set; }
        public long IdD { get; private set; }
        public long IDpriem { get; private set; }
        public string PacName { get; private set; }
        public string Priem_Min { get; private set; }
        public string Priem_Hour { get; private set; }
        public string Priem_Day { get; private set; }
        public string Priem_Month { get; private set; }
        public string Priem_Year { get; private set; }

    }
    public class PacientsBd
    {
        public PacientsBd(long idP, string filename, string phone, string address, string snils, string numPolis)
        {
            IdP = idP;
            PacName = filename;
            Phone = phone;
            Address = address;
            Snils = snils;
            NumPolis = numPolis;
        }
        public long IdP { get; private set; }
        public string PacName { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public string Snils { get; private set; }
        public string NumPolis { get; private set; }

    }
    public class Doctors
    {
        public Doctors(long idD, string filename)
        {
            IdD = idD;
            DocName = filename;

        }
        public long IdD { get; private set; }
        public string DocName { get; private set; }

    }
    public class Bolezni
    {
        public Bolezni(long idD, string filename, string code, string templ)
        {
            IdB = idD;
            BolezniName = filename;
            Code = code;
            Templ = templ;
        }
        public long IdB { get; private set; }
        public string BolezniName { get; private set; }
        public string Code { get; private set; }
        public string Templ { get; private set; }

    }

    public class LEk
    {
        public LEk(long lekid, string filename, string kol)
        {
            Lek_ID = lekid;
            Lekarstvo = filename;
            Kol_Lek = kol;
        }
        public long Lek_ID { get; private set; }
        public string Lekarstvo { get; private set; }
        public string Kol_Lek { get; private set; }

    }

    public class LEkMinus
    {
        public LEkMinus(long skladid, string filename, string kol)
        {
            Sklad_ID = skladid;
            Name_Lek = filename;
            Kol_Lek = kol;
        }
        public long Sklad_ID { get; private set; }
        public string Name_Lek { get; private set; }
        public string Kol_Lek { get; private set; }

    }
    public class GetAllPrint
    {
        public GetAllPrint(string filename, string year, string month, string day, string diagnoz,string code)
        {
            PacName = filename;
            Year = year;
            Month = month;
            Day = day;
            Diagnoz = diagnoz;
            Code = code;
        }
        public string PacName { get; private set; }
        public string Year { get; private set; }
        public string Month { get; private set; }
        public string Day { get; private set; }
        public string Diagnoz { get; private set; }
        public string Code { get; private set; }

    }

    class DAL
    {
        //DEVELOPMENT
        //SQLEXPRESS
        //C:\Program Files\MSSQL12.DEVELOPMENT\MSSQL\DATA\Clinic2.mdf
        //строка соединения
        string connectionString = @"Data Source = DESKTOP-LEBP7C1\DEVELOPMENT;Initial Catalog = Clinic2; Integrated Security = True";
       /* public ArrayList GetAllPacients()
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {    
                SqlCommand com = new SqlCommand("SELECT Polis AS 'Полис' , Last_Name AS 'Фамилия' , Last_Name__200 AS 'Отчество' , Name AS 'Имя', B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год' , Phone AS 'Телефон' , Address AS 'Адрес проживания' , Address_Job AS 'Адрес работы' , Job_Prof AS 'Профессия' FROM Pacients_BD Order By Last_Name ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                   

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPacients.Add(result);
                }
                catch
                {

                }
                
            }
            
            return allPacients;
        }*/
       

        internal object GetAllUslugi(string Pacient_ID)
        {
            ArrayList AllUslugi = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SELECT NazvUslugi AS 'Услуга', Cost AS 'Стоимость услуги' FROM Uslugi WHERE Uslugi_ID IN (SELECT Uslugi_ID FROM lechenie) ", con);

                try
                {
                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            AllUslugi.Add(result);
                }
                catch
                {

                }

            }

            return AllUslugi;
        }

        internal object GetAllLekarstva(string Pacient_ID)
        {
            ArrayList AllLekarstva = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SELECT Lekarstvo AS 'Лекарство', Kol_Lek AS 'Количество лекарства', Cost_Lek AS 'Стоимость лекарства' FROM Lekarstva WHERE Lek_ID IN (SELECT Lek_ID FROM lechenie) ", con);

                try
                {
                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            AllLekarstva.Add(result);
                }
                catch
                {

                }

            }

            return AllLekarstva;
        }

     

        internal object GetAllDiagnoz(long Pacient_ID)
        {
            ArrayList AllDiagnoz = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                //SqlCommand com = new SqlCommand("SELECT teeth_num AS 'Номер зуба', Comments AS 'Комментарии', dataustdiag AS 'Дата диагноза' FROM Diagnoz WHERE Diagnoz_ID IN (SELECT Diagnoz_ID FROM lechenie) ", con);
                //SqlCommand com = new SqlCommand("SELECT * FROM Diagnoz , BOLEZNI ", con);
                //string query = string.Format("SELECT d.Bolezni_ID, d.Diagnoz_ID, b.Bolezni_ID, b.Bolezn,d.dataustdiag AS d_name FROM Diagnoz d INNER JOIN BOLEZNI b ON d.Bolezni_ID = b.Bolezni_ID where d.Pacient_ID={0}",Pacient_ID);
                string query = string.Format("SELECT b.Bolezn,d.dataustdiagY AS Дата FROM Diagnoz d INNER JOIN Bolezni b ON d.Bolezni_ID = b.Bolezni_ID where d.Pacient_ID={0}", Pacient_ID);
                SqlCommand com = new SqlCommand(query,con); 
                //SqlCommand com = new SqlCommand("SELECT d.Bolezni_ID, d.Diagnoz_ID, b.Bolezni_ID, b.Bolezn,d.dataustdiag AS d_name FROM Diagnoz d INNER JOIN BOLEZNI b ON d.Bolezni_ID = b.Bolezni_ID,d.  ", con);
                try
                {
                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            AllDiagnoz.Add(result);
                }
                catch
                {

                }
                
            }

            return AllDiagnoz;
        }
        public ArrayList GetAllPacients()
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {    // SqlCommand com = new SqlCommand("SELECT * FROM Pacients_BD",con);
                SqlCommand com = new SqlCommand("SELECT  Last_Name AS 'Фамилия' ,Name AS 'Имя', Last_Name__200 AS 'Отчество' ,  B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год' ,Polis AS 'Полис' ,Snils AS 'Снилс', Phone AS 'Телефон' ,Pacient_ID AS 'Номер карты',address AS 'Адрес',Job_Prof AS 'Профессия' FROM Pacients_BD Order By Last_Name,Name,Last_Name__200 ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPacients.Add(result);
                    dr.Close();
                }
                catch
                {

                }

                //con.Dispose();
                /*else
                    return null;*/
            }

            return allPacients;
        }
        public ArrayList GetAllc()
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {    // SqlCommand com = new SqlCommand("SELECT * FROM Pacients_BD",con);
                //SqlCommand com = new SqlCommand("SELECT Lekarstvo AS 'Лекарство', Kol_Lek AS 'Количество лекарства', Cost_Lek AS 'Стоимость лекарства' FROM Pacients_BD WHERE Pacient_ID IN (SELECT Pacient_ID FROM Priem) ", con);
                SqlCommand com = new SqlCommand("SELECT pbd.Last_Name AS 'Фамилия' ,pbd.Name AS 'Имя',pbd.Last_Name__200 AS 'Отчество',pr.Priem_hour AS Часы,pr.Priem_min AS Минуты FROM Pacients_BD  pbd INNER JOIN Priem pr ON pbd.Pacient_ID = pr.Pacient_ID where pbd.Pacient_ID IN (SELECT Pacient_ID FROM Priem) Order By pr.Priem_hour ,pr.Priem_min", con);
                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPacients.Add(result);
                    dr.Close();
                }
                catch
                {

                }

                //con.Dispose();
                /*else
                    return null;*/
            }

            return allPacients;
        }
        public ArrayList GetAllPacientsFam(string Fam)
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //string query = string.Format("SELECT  Last_Name AS 'Фамилия',Name AS 'Имя', Last_Name__200 AS 'Отчество' ,  B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год' Polis AS 'Полис' ,,Snils AS 'Снилс', Phone AS 'Телефон' ,Pacient_ID AS 'Номер карты'  FROM Pacients_BD WHERE Last_Name='{0}' Order By Last_Name,Name,Last_Name__200 ", Fam);
                string query = string.Format("SELECT  Last_Name AS 'Фамилия',Name AS 'Имя', Last_Name__200 AS 'Отчество' ,  B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год', Polis AS 'Полис' ,Snils AS 'Снилс', Phone AS 'Телефон' ,Pacient_ID AS 'Номер карты',address AS 'Адрес',Job_Prof AS 'Профессия'  FROM Pacients_BD WHERE Last_Name='{0}' Order By Last_Name,Name,Last_Name__200 ", Fam);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader drr = com.ExecuteReader();

                    if (drr.HasRows)
                        foreach (DbDataRecord result in drr)
                            allPacients.Add(result);
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



                }
                catch
                {

                }

            }

            return allPacients;
        }

        public ArrayList GetAllPacientsName(string Name)
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT  Last_Name AS 'Фамилия', Name AS 'Имя', Last_Name__200 AS 'Отчество', B_Day AS 'День', B_Month AS 'Месяц', B_Year AS 'Год', Polis AS 'Полис', Snils AS 'Снилс', Phone AS 'Телефон', Pacient_ID AS 'Номер карты' ,address AS 'Адрес',Job_Prof AS 'Профессия' FROM Pacients_BD WHERE Name ='{0}' Order By Last_Name,Name,Last_Name__200 ", Name);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader drr = com.ExecuteReader();

                    if (drr.HasRows)
                        foreach (DbDataRecord result in drr)
                            allPacients.Add(result);
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



                }
                catch
                {

                }

            }

            return allPacients;
        }
        public ArrayList GetAllPacientsOtch(string Otch)
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT  Last_Name AS 'Фамилия',Name AS 'Имя', Last_Name__200 AS 'Отчество' ,  B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год', Polis AS 'Полис' ,Snils AS 'Снилс', Phone AS 'Телефон' ,Pacient_ID AS 'Номер карты',address AS 'Адрес',Job_Prof AS 'Профессия'  FROM Pacients_BD WHERE Last_Name__200='{0}' Order By Last_Name,Name,Last_Name__200 ", Otch);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader drr = com.ExecuteReader();

                    if (drr.HasRows)
                        foreach (DbDataRecord result in drr)
                            allPacients.Add(result);
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



                }
                catch
                {

                }

            }

            return allPacients;
        }
        public ArrayList GetAllPacientsTel(string Tel)
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT  Last_Name AS 'Фамилия',Name AS 'Имя', Last_Name__200 AS 'Отчество' ,  B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год', Polis AS 'Полис' ,Snils AS 'Снилс', Phone AS 'Телефон' ,Pacient_ID AS 'Номер карты',address AS 'Адрес',Job_Prof AS 'Профессия'  FROM Pacients_BD WHERE Phone='{0}' Order By Last_Name,Name,Last_Name__200 ", Tel);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader drr = com.ExecuteReader();

                    if (drr.HasRows)
                        foreach (DbDataRecord result in drr)
                            allPacients.Add(result);
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



                }
                catch
                {

                }

            }

            return allPacients;
        }
        public ArrayList GetAllPacientsSnils(string Snils)
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT  Last_Name AS 'Фамилия',Name AS 'Имя', Last_Name__200 AS 'Отчество' ,  B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год', Polis AS 'Полис' ,Snils AS 'Снилс', Phone AS 'Телефон' ,Pacient_ID AS 'Номер карты',address AS 'Адрес',Job_Prof AS 'Профессия'  FROM Pacients_BD WHERE Last_Name='{0}' Order By Last_Name,Name,Last_Name__200 ", Snils);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader drr = com.ExecuteReader();

                    if (drr.HasRows)
                        foreach (DbDataRecord result in drr)
                            allPacients.Add(result);
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



                }
                catch
                {

                }

            }

            return allPacients;
        }
        public ArrayList GetAllPacientsPolis(string Polis)
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT  Last_Name AS 'Фамилия',Name AS 'Имя', Last_Name__200 AS 'Отчество' ,  B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год', Polis AS 'Полис' ,Snils AS 'Снилс', Phone AS 'Телефон' ,Pacient_ID AS 'Номер карты',address AS 'Адрес',Job_Prof AS 'Профессия'  FROM Pacients_BD WHERE Polis='{0}' Order By Last_Name,Name,Last_Name__200 ", Polis);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader drr = com.ExecuteReader();

                    if (drr.HasRows)
                        foreach (DbDataRecord result in drr)
                            allPacients.Add(result);
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);



                }
                catch
                {

                }

            }

            return allPacients;
        }


        public bool InsertPacientInPriem(long ID, long Pacient_ID, string Priem_hour, string Priem_min, long Doctors_ID, string Priem_Day, string Priem_Month, string Priem_Year)
        {
            bool flagResult = false;

            string query = string.Format("INSERT INTO Priem ([ID],[Pacient_ID],[Priem_hour],[Priem_min],[Doctors_ID],[Priem_Day],[Priem_Month],[Priem_Year]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", ID, Pacient_ID, Priem_hour, Priem_min, Doctors_ID, Priem_Day, Priem_Month, Priem_Year);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }
            }
            return flagResult;
        }

        public bool InsertPacientInBD(long Pacient_ID, string Last_Name,
            string Name, string Last_Name__200, string B_Day, string B_Month,
            string B_Year, string Phone, string Address, string Name_Job, string Polis,
            string Job_Prof, string Snils, string Name_Polis)//20 string 1 ID
        {
            bool flagResult = false;

            string query = string.Format("INSERT INTO Pacients_BD" +
        " ([Pacient_ID],[Name],[Last_Name],[Last_Name__200],[B_Day],[B_Month],[B_Year],  [Phone],  [Address],[Name_Polis] ,  [Name_Job], [Polis],[Job_Prof],  [Snils]) " +
            " VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
            Pacient_ID, Name, Last_Name, Last_Name__200, B_Day, B_Month, B_Year, Phone, Address,
                     Name_Job, Name_Polis, Polis, Job_Prof, Snils);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }
            }
            return flagResult;


        }
        public bool InsertPacientInBD(int /*Pacient_ID*/Spec_ID)//20 string 1 ID
        {
            bool flagResult = false;
            string ID = Spec_ID.ToString();
            string Special = "Врач";
            string query = string.Format("INSERT INTO Spec" +
            " ([Spec_ID],[Special]) VALUES ('{0}','{1}')", ID, Special);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }
            }
            return flagResult;


        }
        public List<long> GetPriemPacientsID()
        {
            List<long> PriemPacients = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SELECT Pacient_ID FROM Pacients_BD  ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        PriemPacients.Add(id);
                    }


                }
                catch
                {

                }
            }

            return PriemPacients;
        }
        public List<long> GetPriemPacientsBD()
        {
            List<long> PriemPacients = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Priem  ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        PriemPacients.Add(id);
                    }


                }
                catch
                {

                }
            }

            return PriemPacients;
        }

        public bool InsertDoctorsInBD(long Doctors_ID, string Doc_Name,
            string Doc_Fam, string Doc_Otch, string Doctor_Pass, string Doc_Phone, string Spec, string Login)//20 string 1 ID
        {
            bool flagResult = false;
            //string ID = Spec_ID.ToString();
            //string Special = "Врач";
            string query = string.Format("INSERT INTO Doctors" +
            " ( [Doctors_ID],  [Doc_Name],[Doc_Fam], [Doc_Otch], [Doctor_Pass], [Doctor_Phone], [Spec],[Login])" +
            " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Doctors_ID, Doc_Name,
             Doc_Fam, Doc_Otch, Doctor_Pass, Doc_Phone, Spec, Login);
            /*string query = string.Format("INSERT INTO Doctors ([Doctors_ID],[Doc_Name],[Doc_Fam]) VALUES ('{0}','{1}','{2}')", 
                Doctors_ID,Doc_Name,Doc_Fam);*/

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {

                    // SET IDENTITY_INSERT Doctors ON
                    con.Open();
                    //com.ExecuteNonQuery();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }

            }
            return flagResult;


        }
        public List<long> GetDoctorsID()
        {
            List<long> DoctorsID = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Doctors  ", con);

                try
                {

                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        DoctorsID.Add(id);
                    }
                }
                catch
                {

                }
            }

            return DoctorsID;
        }
        public ArrayList GetAllLek()
        {
            ArrayList AllLek = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {    // SqlCommand com = new SqlCommand("SELECT * FROM Pacients_BD",con);
                SqlCommand com = new SqlCommand("SELECT Lek_ID AS 'ID' ,Lekarstvo AS 'Лекарственное средство',Kol_Lek AS 'Количество' FROM Lekarstva Order By Lekarstvo ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            AllLek.Add(result);
                    dr.Close();
                }
                catch
                {

                }

                //con.Dispose();
                /*else
                    return null;*/
            }

            return AllLek;
        }
        public List<long> GetLekID()
        {
            List<long> LekID = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Lekarstva  ", con);

                try
                {

                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt32(0);
                        LekID.Add(id);
                    }
                }
                catch
                {

                }
            }

            return LekID;
        }
        public bool InsertLekInBD(long Lek_ID, string Lekarstvo, string Kol_Lek)//20 string 1 ID
        {
            bool flagResult = false;
            string query = string.Format("INSERT INTO Lekarstva" +
            " ( [Lek_ID],  [Lekarstvo],[Kol_Lek])" +
            " VALUES ('{0}','{1}','{2}')", Lek_ID, Lekarstvo,
             Kol_Lek);


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {

                    // SET IDENTITY_INSERT Doctors ON
                    con.Open();
                    //com.ExecuteNonQuery();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }

            }
            return flagResult;
        }
        public ArrayList GetAllLekName(string name)
        {
            ArrayList allPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT Lek_ID AS 'ID',Lekarstvo AS 'Лекарственное средство',Kol_Lek AS 'Количество'  FROM Lekarstva WHERE Lekarstvo='{0}' Order By Lekarstvo ", name);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader drr = com.ExecuteReader();

                    if (drr.HasRows)
                        foreach (DbDataRecord result in drr)
                            allPacients.Add(result);

                }
                catch
                {

                }

            }

            return allPacients;
        }
        public bool InsertOldLekInBD(long Lek_ID, string Lekarstvo, string Kol_Lek)//20 string 1 ID
        {
            bool flagResult = false;
            /* string query = string.Format("INSERT INTO Lekarstva" +
             " ( [Lek_ID],  [Lekarstvo],[Kol_Lek])" +
             " VALUES ('{0}','{1}','{2}')", Lek_ID, Lekarstvo,
              Kol_Lek);*/
            string query = string.Format("UPDATE Lekarstva SET Kol_Lek = '{1}' where Lek_ID = '{0}'", Lek_ID, Kol_Lek);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {

                    // SET IDENTITY_INSERT Doctors ON
                    con.Open();
                    //com.ExecuteNonQuery();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }

            }
            return flagResult;
        }
        public List<long> GetBolID()
        {
            List<long> BolID = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT Bolezni_ID FROM Bolezni  ", con);

                try
                {

                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        BolID.Add(id);
                    }
                }
                catch
                {

                }
            }

            return BolID;
        }
        public bool InsertBolInBD(long Bolezni_ID, string Bolezn, string code, string Templ)//20 string 1 ID
        {
            bool flagResult = false;
            /*string query = string.Format("INSERT INTO Bolezni" +
            " ( [Bolezni_ID],  [Bolezn],[Template],[code])" +
            " VALUES ('{0}','{1}','{2}','{3}')", Bolezni_ID, Bolezn,
             Template, code);*/
            string query = string.Format("INSERT INTO Bolezni" +
           " ( [Bolezni_ID],[Bolezn],[code],[Template])" +
           " VALUES ('{0}','{1}','{2}','{3}')", Bolezni_ID, Bolezn, code, Templ);


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {

                    // SET IDENTITY_INSERT Doctors ON
                    con.Open();
                    //com.ExecuteNonQuery();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }

            }
            return flagResult;
        }
        public List<long> GetSKLADID()
        {
            List<long> SKLADID = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Sklad  ", con);

                try
                {

                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        SKLADID.Add(id);
                    }
                }
                catch
                {

                }
            }

            return SKLADID;
        }
        public bool InsertSkaldBInBD(long Sklad_ID, string Name_Lek, string Kol_lek, long Bolezni_ID)//20 string 1 ID
        {
            bool flagResult = false;
            string query = string.Format("INSERT INTO Sklad" +
            " ( [Sklad_ID],  [Name_Lek],[Kol_lek],[Bolezni_ID])" +
            " VALUES ('{0}','{1}','{2}','{3}')", Sklad_ID, Name_Lek,
             Kol_lek, Bolezni_ID);


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {

                    // SET IDENTITY_INSERT Doctors ON
                    con.Open();
                    //com.ExecuteNonQuery();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }

            }
            return flagResult;
        }
        public ArrayList GetAllLekSkald(long IDBOL)
        {
            ArrayList AllLek = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {    // SqlCommand com = new SqlCommand("SELECT * FROM Pacients_BD",con);
                string query = string.Format("SELECT Sklad_ID AS 'ID' ,Name_Lek AS 'Лекарственное средство',Kol_lek AS 'Используемое количество',Bolezni_ID AS 'IDBol' FROM Sklad WHERE Bolezni_ID='{0}' Order By Name_Lek ", IDBOL);
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            AllLek.Add(result);
                    dr.Close();
                }
                catch
                {

                }

                //con.Dispose();
                /*else
                    return null;*/
            }

            return AllLek;
        }

        public List<Pacients> GetTimePac()
        {
            List<Pacients> TimePac = new List<Pacients>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Priem  ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long IDP = dr.GetInt64(0);
                        long idP = dr.GetInt64(1);
                        long idD = dr.GetInt64(4);
                        string min = dr.GetString(3);
                        string hour = dr.GetString(2);
                        string day = dr.GetString(5);
                        string month = dr.GetString(6);
                        string year = dr.GetString(7);
                        string filename = "";
                        string query = String.Format("SELECT * FROM Pacients_BD WHERE Pacient_ID='{0}' ", idP);
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            try
                            {


                                conn.Open();
                                SqlCommand comm = new SqlCommand(query, conn);
                                SqlDataReader drr = comm.ExecuteReader();
                                while (drr.Read())
                                {
                                    filename = drr.GetString(2) + " " + drr.GetString(1) + " " + drr.GetString(3);
                                }
                            }
                            catch
                            { }
                        }
                        Pacients pacients = new Pacients(idP, idD, filename, min, hour, day, month, year,IDP);
                        TimePac.Add(pacients);
                    }


                }
                catch
                {

                }
            }

            return TimePac;
        }

        public List<Doctors> GetDoctors()
        {
            List<Doctors> Doctors = new List<Doctors>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("SELECT * FROM Doctors  ", con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        long idD = dr.GetInt64(0);
                        string filename = "";
                        filename = dr.GetString(2) + " " + dr.GetString(1) + " " + dr.GetString(3);
                        Doctors doctors = new Doctors(idD, filename);
                        Doctors.Add(doctors);
                    }


                }
                catch
                {

                }
            }

            return Doctors;
        }

        public List<long> GetPriemPacients()
        {
            List<long> PriemPacients = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SELECT Pacient_ID FROM Pacients_BD  ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        PriemPacients.Add(id);
                    }


                }
                catch
                {

                }
            }

            return PriemPacients;
        }
        public long GetDoctorsIDBD(string Login,string Pass)
        {
            List<long> DoctorsIDBD = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Doctors where Login='{0}' and Doctor_Pass='{1}' ", Login,Pass);
                //string query = String.Format("SELECT * FROM Doctors where Login='{0}' ", Login);
                SqlCommand com = new SqlCommand(query, con);
               
                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        return id;
                        //DoctorsIDBD.Add(id);
                    }


                }
                catch
                {

                }
            }
            return 0;
            //return DoctorsIDBD;
        }
        public List<PacientsBd> GetInfoPac(long IdPac)
        {
            List<PacientsBd> TimePac = new List<PacientsBd>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query1 = string.Format("SELECT * FROM Pacients_BD where Pacient_ID= '{0}'", IdPac);
                SqlCommand com = new SqlCommand(query1, con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long idP = dr.GetInt64(0);
                        string Fam = dr.GetString(2);
                        Fam +=" " + dr.GetString(1);
                        Fam += " " + dr.GetString(3);
                        string phone = dr.GetString(7);
                        string address = dr.GetString(8);
                        string snils = dr.GetString(13);
                        string polis = dr.GetString(11);
                        PacientsBd pacientsBd = new PacientsBd(idP, Fam, phone, address, snils, polis);
                        TimePac.Add(pacientsBd);
                        return TimePac;
                    }


                }
                catch
                {

                }
            }

            return TimePac;
        }
        public ArrayList GetAllBol()
        {
            ArrayList AllLek = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {    // SqlCommand com = new SqlCommand("SELECT * FROM Pacients_BD",con);
                string query = string.Format("SELECT Bolezni_ID AS 'ID' ,Bolezn AS 'Болезнь',code AS 'Код ',Template AS 'Шаблон' FROM Bolezni  Order By Bolezn ");
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            AllLek.Add(result);
                    dr.Close();
                }
                catch
                {

                }

                //con.Dispose();
                /*else
                    return null;*/
            }

            return AllLek;
        }
        public List<Bolezni> GetInfoBol()
        {
            List<Bolezni> InfoBol = new List<Bolezni>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query1 = string.Format("SELECT * FROM Bolezni");
                SqlCommand com = new SqlCommand(query1, con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long idB = dr.GetInt64(0);
                        string Name = dr.GetString(1);
                        string code = dr.GetString(2);
                        string templ = dr.GetString(3);
                        Bolezni bolezni = new Bolezni(idB, Name, code, templ);
                        InfoBol.Add(bolezni);
                    }
                }
                catch
                {

                }
            }

            return InfoBol;
        }
        public bool InsertPacientInDiagnoz(long Bolezni_ID, string dataustdiagY, long IDD, long Diagnoz_ID, long Pacient_ID, string dataustdiagM, string dataustdiagD, long Doctor_ID)
        {
            bool flagResult = false;

            string query = string.Format("INSERT INTO Diagnoz ([Bolezni_ID],[dataustdiagY],[ID],[Diagnoz_ID],[Pacient_ID],[dataustdiagM],[dataustdiagD],[Doctor_ID]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Bolezni_ID, dataustdiagY, IDD, Diagnoz_ID, Pacient_ID, dataustdiagM, dataustdiagD, Doctor_ID);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }
            }
            return flagResult;
        }
        public List<long> GetDiagnozPacients()
        {
            List<long> PriemPacients = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SELECT Diagnoz_ID FROM Diagnoz  ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        PriemPacients.Add(id);
                    }


                }
                catch
                {

                }
            }

            return PriemPacients;
        }
        public List<LEk> GetSklad()
        {
            List<LEk> getSklad = new List<LEk>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query1 = string.Format("SELECT * FROM Lekarstva ");
                SqlCommand com = new SqlCommand(query1, con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long lekid = dr.GetInt32(0);
                        string namelek = dr.GetString(1);
                        string kol = dr.GetString(3);
                        LEk lek = new LEk(lekid, namelek, kol);
                        getSklad.Add(lek);
                    }


                }
                catch
                {

                }
            }

            return getSklad;
        }
        public List<LEkMinus> GetBolSklad(long Bolezni_ID)
        {
            List<LEkMinus> BolSklad = new List<LEkMinus>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query1 = string.Format("SELECT * FROM Sklad where Bolezni_ID= '{0}'", Bolezni_ID);
                SqlCommand com = new SqlCommand(query1, con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long skladid = dr.GetInt64(0);
                        string namelek = dr.GetString(1);
                        string kol = dr.GetString(2);
                        LEkMinus lekminus = new LEkMinus(skladid, namelek, kol);
                        BolSklad.Add(lekminus);
                    }


                }
                catch
                {

                }
            }

            return BolSklad;
        }
        public bool UpdateLek(long Lek_ID, string Lekarstvo, string Kol_Lek)//20 string 1 ID
        {
            bool flagResult = false;
            /* string query = string.Format("INSERT INTO Lekarstva" +
             " ( [Lek_ID],  [Lekarstvo],[Kol_Lek])" +
             " VALUES ('{0}','{1}','{2}')", Lek_ID, Lekarstvo,
              Kol_Lek);*/
            string query = string.Format("UPDATE Lekarstva SET Kol_Lek = '{1}' where Lek_ID = '{0}'", Lek_ID, Kol_Lek);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {

                    // SET IDENTITY_INSERT Doctors ONs
                    con.Open();
                    //com.ExecuteNonQuery();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }

            }
            return flagResult;
        }

        public List<GetAllPrint> AllForPrint(long DocId)
        {
            List<GetAllPrint> ForPrint = new List<GetAllPrint>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query1 = String.Format("SELECT * FROM Diagnoz where Doctor_ID='{0}' ",DocId);
                SqlCommand com = new SqlCommand(query1, con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long idP = dr.GetInt64(5);
                        long idB = dr.GetInt64(0);
                        string day = dr.GetString(7);
                        string month = dr.GetString(6);
                        string year = dr.GetString(1);
                        string filename = "";
                        string diagnoz="";
                        string code = "";
                        string query = String.Format("SELECT * FROM Pacients_BD WHERE Pacient_ID='{0}' ", idP);
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            try
                            {


                                conn.Open();
                                SqlCommand comm = new SqlCommand(query, conn);
                                SqlDataReader drr = comm.ExecuteReader();
                                while (drr.Read())
                                {
                                    filename = drr.GetString(2) + " " + drr.GetString(1) + " " + drr.GetString(3);
                                }
                            }
                            catch
                            { }
                        }
                        string query2 = String.Format("SELECT * FROM Bolezni WHERE Bolezni_ID='{0}' ", idB);
                        using (SqlConnection connn = new SqlConnection(connectionString))
                        {
                            try
                            {


                                connn.Open();
                                SqlCommand commm = new SqlCommand(query2, connn);
                                SqlDataReader drrr = commm.ExecuteReader();
                                while (drrr.Read())
                                {
                                    diagnoz = drrr.GetString(1);
                                    code = drrr.GetString(2);
                                }
                            }
                            catch
                            { }
                        }
                        GetAllPrint pacients = new GetAllPrint(filename, year, month, day, diagnoz, code);
                        ForPrint.Add(pacients);
                    }


                }
                catch
                {

                }
            }

            return ForPrint;
        }
    }
}

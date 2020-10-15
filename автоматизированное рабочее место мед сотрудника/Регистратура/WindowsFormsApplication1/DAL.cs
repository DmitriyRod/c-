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
        public Pacients(long idP, long idD, string filename, string min, string hour, string day, string month, string year)
        {
            IdP = idP;
            IdD = idD;
            PacName = filename;
            Priem_Min = min;
            Priem_Hour = hour;
            Priem_Day = day;
            Priem_Month = month;
            Priem_Year = year;
        }
        public long IdP { get; private set; }
        public long IdD { get; private set; }
        public string PacName { get; private set; }
        public string Priem_Min { get; private set; }
        public string Priem_Hour { get; private set; }
        public string Priem_Day { get; private set; }
        public string Priem_Month { get; private set; }
        public string Priem_Year { get; private set; }

    }
    public class Doctors
    {
        public Doctors( long idD, string filename)
        {
            IdD = idD;
            DocName = filename;
            
        }
        public long IdD { get; private set; }
        public string DocName { get; private set; }

    }

    class DAL
    {
        //DEVELOPMENT
        //SQLEXPRESS
        //C:\Program Files\MSSQL12.DEVELOPMENT\MSSQL\DATA\Clinic2.mdf
        //строка соединения
        string connectionString = @"Data Source = DESKTOP-LEBP7C1\DEVELOPMENT;Initial Catalog = Clinic2; Integrated Security = True";
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
        public ArrayList GetAllPriemPacients()
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


        public bool InsertPacientInPriem(long ID,long Pacient_ID, string Priem_hour, string Priem_min,long Doctors_ID, string Priem_Day, string Priem_Month, string Priem_Year)
        {
            bool flagResult = false;
 
            string query = string.Format("INSERT INTO Priem ([ID],[Pacient_ID],[Priem_hour],[Priem_min],[Doctors_ID],[Priem_Day],[Priem_Month],[Priem_Year]) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", ID, Pacient_ID, Priem_hour, Priem_min,Doctors_ID,Priem_Day,Priem_Month,Priem_Year);
            
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
                     Name_Job, Name_Polis, Polis, Job_Prof, Snils );

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
                        long idP = dr.GetInt64(1);
                        long idD = dr.GetInt64(4);
                        string min = dr.GetString(3);
                        string hour = dr.GetString(2);
                        string day = dr.GetString(5);
                        string month = dr.GetString(6);
                        string year = dr.GetString(7);
                        string filename="";
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
                        Pacients pacients = new Pacients( idP, idD,filename, min, hour, day, month, year);
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
                        filename = dr.GetString(2)+ " " + dr.GetString(1) + " " + dr.GetString(3);
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
        public bool GetCurrentIDPacients(int ID)
        {
            List<long> PriemPacients = new List<long>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT Pacient_ID FROM Pacients_BD where Pacient_ID='{0}'", ID);

                    SqlCommand com = new SqlCommand(query, con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();


                    while (dr.Read())
                    {
                        //int id = Convert.ToInt32(dr.GetInt32(0));
                        long id = dr.GetInt64(0);
                        PriemPacients.Add(id);
                        return true;
                    }


                }
                catch
                {

                }
            }

            return false;
        }
    }
}


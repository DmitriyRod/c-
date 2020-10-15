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
                SqlCommand com = new SqlCommand("SELECT Polis AS 'Полис' , Last_Name AS 'Фамилия' , Last_Name__200 AS 'Отчество' , Name AS 'Имя', B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год' , Phone AS 'Телефон' , Address AS 'Адрес проживания' , Address_Job AS 'Адрес работы' , Job_Prof AS 'Профессия' FROM Pacients_BD Order By Last_Name ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPacients.Add(result);
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
        public ArrayList GetPriemPacients()
        {
            ArrayList PriemPacients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {    // SqlCommand com = new SqlCommand("SELECT * FROM Pacients_BD",con);
                SqlCommand com = new SqlCommand("SELECT Polis AS 'Полис' , Last_Name AS 'Фамилия' , Last_Name__200 AS 'Отчество' , Name AS 'Имя', B_Day AS 'День', B_Month AS 'Месяц',B_Year AS 'Год' , Phone AS 'Телефон' , Address AS 'Адрес проживания' , Address_Job AS 'Адрес работы' , Job_Prof AS 'Профессия' FROM Pacients_BD Order By Last_Name ", con);

                try
                {


                    con.Open();

                    SqlDataReader dr = com.ExecuteReader();
                    // SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            PriemPacients.Add(result);
                }
                catch
                {

                }
                //con.Dispose();
                /*else
                    return null;*/
            }

            return PriemPacients;
        }
    }
}

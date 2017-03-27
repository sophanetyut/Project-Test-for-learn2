using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            Program.CheckData(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), 8);

            //Program.CheckData(new DateTime(2017,03,09), 8);
            //Console.ReadKey();
            //Console.WriteLine(Environment.NewLine);


            //for (int i = 0; i < str.GetLength(0); i++)
            //{
            //    for (int j = 0; j < str.GetLength(1); j++)
            //    {
            //        Console.WriteLine(str[i, j]);
            //    }
            //}
        }
        private static string[,] str={ {"","","",""} };
        private static void CheckData(DateTime date, int Hour)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection("Data Source=(local); Database=IndradhanuClinic; Trusted_Connection=True;"))
            {
                SqlCommand command = new SqlCommand(@"SELECT tbl_Registration.Name, (select dbo.fn_Phone(tbl_Registration.Phone))as Phone, tbl_Alocated.Name, Email FROM tbl_Registration LEFT JOIN 
                                                     tbl_Registration_sub on tbl_Registration_sub.SN = tbl_Registration.SN LEFT JOIN tbl_Alocated ON tbl_Alocated.AlocateID = tbl_Registration_sub.Alocated WHERE DATEPART(HOUR, MeetingTime) = @hour AND ApointmentDate = @date ;", connection);
                command.Parameters.AddWithValue("@hour", Hour);
                command.Parameters.AddWithValue("@date", date);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet, "FuckData");
                DataTable dataTable = dataSet.Tables[0];
                int x = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    int y = 0;
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        Console.WriteLine(item[col]);
                        Console.WriteLine(x+" "+y);
                        str[x, y] = item[col].ToString();
                        y++;
                    }
                    x++;
                }

            }
        }
    }
}

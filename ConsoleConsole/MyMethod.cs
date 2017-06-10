using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleConsole
{
    class MyMethod
    {
        

        public static bool CheckServices(string ServiceName)
        {
            ServiceController sc = new ServiceController(ServiceName);
            bool s = false;
            try
            {
                if (sc.Status != ServiceControllerStatus.Running)
                {
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);
                    // sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10.00));
                }
            }
            catch (Exception)
            {
                s = true;
            }
            return s;
        }//check merl mean services name pong run ot


        private static string[,] str = { { "", "", "", "" } };
        private static void CheckData(DateTime date, int Hour)
        {
            //DataSet dataSet = new DataSet();
            //using (SqlConnection connection = new SqlConnection("Data Source=(local); Database=IndradhanuClinic; Trusted_Connection=True;"))
            //{
            //    SqlCommand command = new SqlCommand(@"SELECT tbl_Registration.Name, (select dbo.fn_Phone(tbl_Registration.Phone))as Phone, tbl_Alocated.Name, Email FROM tbl_Registration LEFT JOIN 
            //                                         tbl_Registration_sub on tbl_Registration_sub.SN = tbl_Registration.SN LEFT JOIN tbl_Alocated ON tbl_Alocated.AlocateID = tbl_Registration_sub.Alocated WHERE DATEPART(HOUR, MeetingTime) = @hour AND ApointmentDate = @date ;", connection);
            //    command.Parameters.AddWithValue("@hour", Hour);
            //    command.Parameters.AddWithValue("@date", date);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    adapter.Fill(dataSet, "FuckData");
            //    DataTable dataTable = dataSet.Tables[0];
            //    int x = 0;
            //    foreach (DataRow item in dataTable.Rows)
            //    {
            //        int y = 0;
            //        foreach (DataColumn col in dataTable.Columns)
            //        {
            //            Console.WriteLine(item[col]);
            //            Console.WriteLine(x + " " + y);
            //            str[x, y] = item[col].ToString();
            //            y++;
            //        }
            //        x++;
            //    }

            //}
        }





        
    }
}

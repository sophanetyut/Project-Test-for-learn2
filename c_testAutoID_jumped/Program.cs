using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace c_testAutoID_jumped
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Server=(local);Database=IndradhanuClinic;User Id=sa;Password = 123; ");
            SqlCommand comm = new SqlCommand("INSERT INTO tbl_Registration VALUES('name 1',0, '06.02.1994','5y 2m','06.05.2012','f name1', 'm name1','012 369 987', 'Address 1', 'Complain')",con);
            SqlCommand comm2 = new SqlCommand("INSERT INTO tbl_Registration VALUES('name 1',0, '06.02.1994','AbcdefghIjklmnopqrs','06.05.2012','f name1', 'm name1','012 369 987', 'Address 1', 'Complain')", con);
            try
            {
                con.Open();
                comm.ExecuteNonQuery();
                //comm2.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception exx)
            {
                con.Close();
                Console.WriteLine(exx.ToString());
            }

            Console.Read();
            
        }
    }
}

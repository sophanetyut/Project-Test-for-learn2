using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Bing.Speech;
using System.ServiceProcess;


namespace bingSpeechTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Checking SQLServer Service");
            ServiceController sc = new ServiceController("MSSQLSERVER");
            switch (sc.Status)
            {
                case ServiceControllerStatus.Stopped:
                    Console.WriteLine("Stoped");
                    sc.Start();
                    break;
                case ServiceControllerStatus.StopPending:
                    Console.WriteLine("Stop Pending");
                    break;
                default:
                    break;
            }

            //if (sc.Status!=ServiceControllerStatus.Running)
            //{
            //    try
            //    {
            //        sc.Start();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Can not start the services."+ex);
            //    }
            //}
            Console.ReadKey();
        }
    }
}

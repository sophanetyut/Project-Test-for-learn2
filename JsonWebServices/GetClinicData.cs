using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace JsonWebServices
{
    public class GetClinicData : IHttpHandler
    {
        DataSet1.tbl_RegistrationDataTable tbAdt;
        DataSet1TableAdapters.tbl_RegistrationTableAdapter ta;
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                switch (context.Request.HttpMethod)
                {
                    case "POS":
                        break;
                    case "GET":
                        ta = new DataSet1TableAdapters.tbl_RegistrationTableAdapter();
                        tbAdt = ta.GetData();

                        string json = string.Empty;
                        json = JsonConvert.SerializeObject(tbAdt);
                        HttpContext.Current.Response.Write(json);

                        break;
                }

            }
            catch (Exception)
            {
                HttpContext.Current.Response.Write("Error on Webservices while access to Clinic");
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace web_service_test
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Description ="Serviciu web pentru C#", Name ="Primul serviciu web",Namespace ="Serviciu_web")]
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string generateUrl(string link1, string link2)
        {
            return link1 + link2;
        }

        [WebMethod (Description ="add two numbers")]
        public double add(double a, double b)
        {
            return a+b;
        }

        [WebMethod(Description = "loads data")]
        public void load()
        {
            DataSet dsUniv;
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsUniv = new DataSet();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            

            myCon.Close();
        }
    }
}

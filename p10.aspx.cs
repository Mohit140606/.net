using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace yagnesh
{
    public partial class p10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection();
            cn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP2\\Desktop\\.net\\yagnesh\\App_Data\\Database1.mdf;Integrated Security=True";
            cn.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from friend";
            System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                DateTime dt = (DateTime)dr.GetValue(2);
                DateTime dt1 = e.Day.Date;
                if (dt.Month == dt1.Month)
                {
                    if(Convert.ToString (dt.Day)==e.Day.DayNumberText)
                    {
                        int n = (int)dr.GetValue(0);
                        LiteralControl l = new LiteralControl("<br /><a href=Default2.aspx?x=" + n + ">BirthDay</a>");
                        e.Cell.Controls.Add(l);
                    }
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
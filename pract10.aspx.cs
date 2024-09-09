using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace unit2
{
    public partial class pract10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP.net\\unit2\\App_Data\\Database2.mdf;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from FriendsDetail";
           
            SqlDataAdapter da=new SqlDataAdapter();
            System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                DateTime dt = (DateTime)dr.GetValue(2);
                DateTime dt1 = e.Day.Date;

                if(dt.Month==dt1.Month)
                {
                    if(Convert.ToString(dt.Day) == e.Day.DayNumberText)
                    {
                        // int n = (int)dr.GetValue(0);
                        int n = (int)dr.GetValue(0);
                        LiteralControl l = new LiteralControl("<br/><a href=pract10_1.aspx?x="+ n +">Birthday</a>");
                        // LiteralControl l = new LiteralControl("<br/><a href=pract10_1.aspx?x= " + n +">Birthday</a>");
                        e.Cell.Controls.Add(l);


                    }
                }
            }
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace unit2
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["mymultyvalcookie"] != null)
            {
                Label1.Text = "<B>Item No:</B>" +
                Request.Cookies["mymultyvalcookie"]["I_No"];
                Label2.Text = "<B>Item Name:</B>" +
                Request.Cookies["mymultyvalcookie"]["I_Name"];
                Label3.Text = "<B>Item Qty:</B>" +
                Request.Cookies["mymultyvalcookie"]["I_Qty"];
                Label4.Text = "<B>Item Price:</B>" +
                Request.Cookies["mymultyvalcookie"]["I_Price"];
            }
        }
    }
}
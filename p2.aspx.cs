using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace unit2
{
    public partial class p2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Clr = "White";
            foreach(ListItem i in RadioButtonList1.Items)
            {
                if (i.Selected == true)
                    Clr = i.Text;
            }
            MyBody.Style[HtmlTextWriterStyle.BackgroundColor] = Clr;
        }
    }
}
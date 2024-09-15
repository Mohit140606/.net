using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace unit2
{
    public partial class p6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Server.MapPath("~/Image-Folder"));
            DataList1.DataSource = di.GetFiles();
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                if(FileUpload1.FileContent.Length < 10000)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Image-Folder/" + FileUpload1.FileName));
                }
            }
        }
    }
}
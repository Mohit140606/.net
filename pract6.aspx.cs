using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace unit2
{
    public partial class pract6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Server.MapPath("~/image_folder"));
            DataList1.DataSource = di.GetFiles();
            DataList1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                if(FileUpload1.FileContent.Length < 1000000)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/image_folder/" + FileUpload1.FileName));
                }
            }
        }
    }
}
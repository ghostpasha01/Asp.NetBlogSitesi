using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLDENEYİMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYİMTableAdapter();
            dt.DeneyimSil(Convert.ToInt16(x));
            Response.Redirect("AdminDeneyimler.Aspx");
            //silme işlemi sonra bakılacak.
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class HobiSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //burda da hata veriyor düzenlenecek
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLHOBİLERTableAdapter dt = new DataSet1TableAdapters.TBLHOBİLERTableAdapter();
            dt.HobiSil(Convert.ToInt16(x));
            Response.Redirect("HobiListesi.Aspx");
        }
    }
}
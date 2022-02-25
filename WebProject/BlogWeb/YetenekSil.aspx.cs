using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //burası hata veriyor duzenlencek.
            
            DataSet1TableAdapters.TBLDENEYİMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYİMTableAdapter();
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            dt.DeneyimSil(Convert.ToInt16(x));
            Response.Redirect("YetenekListesi.Aspx");  
                
                
                }
    }
}
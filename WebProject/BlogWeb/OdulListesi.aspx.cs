using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class OdullerLisetesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLODULLERTableAdapter dt = new DataSet1TableAdapters.TBLODULLERTableAdapter();
            Repeater1.DataSource = dt.OdulListesi();
            Repeater1.DataBind();
        }
    }
}
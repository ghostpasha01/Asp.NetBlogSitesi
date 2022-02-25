using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListe();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDENEYİMTableAdapter dt1 = new DataSet1TableAdapters.TBLDENEYİMTableAdapter();
            Repeater2.DataSource = dt1.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEGITIMTableAdapter dt2 = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource = dt2.EgitimListesi();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLHOBİLERTableAdapter dt3 = new DataSet1TableAdapters.TBLHOBİLERTableAdapter();
            Repeater4.DataSource = dt3.HobiListesi();
            Repeater4.DataBind();

            DataSet1TableAdapters.TBLODULLERTableAdapter dt4 = new DataSet1TableAdapters.TBLODULLERTableAdapter();
            Repeater5.DataSource = dt4.OdulListesi();
            Repeater5.DataBind();
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt5 = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            Repeater6.DataSource = dt5.YetenekListesi();
            Repeater6.DataBind();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitmEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimEkle(txtBaslık.Text, txtAltbaslık.Text, txtAcıklama.Text, txtGenelnotOrt.Text, txtTarıh.Text);
            Response.Redirect("AdminEgitimler.Aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimEkle(txtBaslık.Text, txtAltbaslık.Text, txtAcıklama.Text, txtGenelnotOrt.Text, txtTarıh.Text);
            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimGüncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////buradan hata alıyorum tekrar bakılacak.
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtId.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLDENEYİMTableAdapter dt1 = new DataSet1TableAdapters.TBLDENEYİMTableAdapter();
                txtBaslık.Text = dt1.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                txtAltbaslık.Text = dt1.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                txtAcıklama.Text = dt1.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                txtTarıh.Text = dt1.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYİMTableAdapter dt = new DataSet1TableAdapters.TBLDENEYİMTableAdapter();
            dt.DeneyimGuncelle(txtBaslık.Text, txtAltbaslık.Text, txtAcıklama.Text, txtTarıh.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("AdminDeneyimler.Aspx");
        }
    }
}
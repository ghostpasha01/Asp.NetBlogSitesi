using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Burasıda aynı hatayı veriyor duzenlecek.
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Enabled = false;
            txtID.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                txtBaslık.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].BASLIK.ToString();
                txtAltbaslık.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK.ToString();
                txtAcıklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA.ToString();
                txtTarıh.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].TARIH.ToString();
                txtGenelnotOrt.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].GNOT.ToString();



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //buda aynı hatayı veriyor.
            DataSet1TableAdapters.TBLEGITIMTableAdapter dt = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dt.EgitimGuncelle(txtBaslık.Text, txtAltbaslık.Text, txtAcıklama.Text, txtGenelnotOrt.Text, txtTarıh.Text
                , Convert.ToInt16(txtID.Text));
            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}
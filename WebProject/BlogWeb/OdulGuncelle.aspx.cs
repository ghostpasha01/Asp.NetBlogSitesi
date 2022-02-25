using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class OdulGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = x.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLODULLERTableAdapter dt = new DataSet1TableAdapters.TBLODULLERTableAdapter();
                txtOdul.Text = dt.OdulGetir(Convert.ToInt16(x))[0].ODUL;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLODULLERTableAdapter dt = new DataSet1TableAdapters.TBLODULLERTableAdapter();
            dt.OdulGuncelle(txtOdul.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("OdulListesi.Aspx");

        }
    }
}
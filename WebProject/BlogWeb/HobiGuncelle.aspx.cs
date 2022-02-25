using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = x.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLHOBİLERTableAdapter dt = new DataSet1TableAdapters.TBLHOBİLERTableAdapter();
                txtHobi.Text = dt.HobiGetir(Convert.ToInt16(txtID.Text))[0].HOBİ;

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBİLERTableAdapter dt = new DataSet1TableAdapters.TBLHOBİLERTableAdapter();
            dt.HobiGuncelle(txtHobi.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("HobiLisetesi");
        }
    }
}
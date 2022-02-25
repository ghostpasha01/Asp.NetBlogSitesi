﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //bu iki blokta hata veriyor bakılacak


            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtID.Text = x.ToString();
            txtID.Enabled = false;
            if (Page.IsPostBack == false) { 
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            txtYetenek.Text = dt.YetenekGetir(Convert.ToInt16(x))[0].YETENEK;
        }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKLERTableAdapter dt =
            new DataSet1TableAdapters.TBLYETENEKLERTableAdapter();
            dt.YetenekGuncelle(txtYetenek.Text, Convert.ToInt16(txtID.Text));
            Response.Redirect("YetenekListesi.Aspx");

        }
    }
}
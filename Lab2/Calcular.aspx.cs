﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2
{
    public partial class Calcular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDato_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Session["Usuario"].ToString(); 
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Seguridad_Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/Seguridad/Login.aspx");
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class offers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string email = (string)Session["email"];
        if (email != null)
        {
            signin.Visible = false;
        }
        else

            signout.Visible = false;
    }
}
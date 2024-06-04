﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBookReviews_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewBookLogin.aspx");
    }

    protected void btnStockManagement_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockManagementSystemLogin.aspx");
    }
}
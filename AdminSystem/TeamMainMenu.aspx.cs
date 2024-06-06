using System;
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

    protected void btnReview_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewBookLogin.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockManagementSystemLogin.aspx");

    }

    protected void btnUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserManagementSystemLogin.aspx");
    }

    protected void btnBookClassification_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookClassificationSystemLogin.aspx");
    }

    protected void btnOrderProcessing_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLogin.aspx");

    }
}
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReviewBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsReviewUser anUser = new clsReviewUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = anUser.FindUser(UserName, Password);

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a Username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password";
        }
        else if (Found == true)
        {
            Response.Redirect("ReviewManagementSystemList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please Try Again";
        }
    }
}
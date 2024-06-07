using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variabel to store the primary key vlaue of the record to be deleted
    Int32 UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the nubmer of the user to be deleted from the sessoin
        UserId = Convert.ToInt32(Session["UserId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {

        //create an instance of the stock collection class
        clsUserCollection Userbook = new clsUserCollection();
        //find the record to delete
        Userbook.ThisUser.Find(UserId);
        //delete the record
        Userbook.Delete();
        //redirect back the the main page
        Response.Redirect("UserManagementSystemList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("UserManagementSystemList.aspx");

    }
}
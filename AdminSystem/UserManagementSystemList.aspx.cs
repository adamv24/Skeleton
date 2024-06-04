using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (!IsPostBack == false)
        {
            //update the lsit box
            DisplayUsers();
        }
    }

    void DisplayUsers()
    {
        //create an instance of the user collection 
        clsUserCollection Users = new clsUserCollection();
        //set the data source to list of users in the collection
        lstUserList.DataSource = Users.UserList;
        //set the name of the primary key
        lstUserList.DataValueField = "UserId";
        //set the data field to display
        lstUserList.DataTextField = "Name";
        //bind the data to list
        lstUserList.DataBind(); 
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["UserId"] = -1;
        //redirect to the data entry page
        Response.Redirect("UserManagementSystemDataEntry.aspx");
    }
}
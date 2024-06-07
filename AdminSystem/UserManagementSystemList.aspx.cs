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
        if (IsPostBack == false)
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the recrod to be edited
        Int32 UserId;
        //if a recrod has been selected from the list
        if (lstUserList.SelectedIndex != -1)
        {
            //get the primary key value of the recrod to edit
            UserId = Convert.ToInt32(lstUserList.SelectedValue);
            //store the data in the session object
            Session["UserId"] = UserId;
            //redirect to the edit page
            Response.Redirect("UserManagementSystemDataEntry.aspx");
        }
        else    //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //varaiable to store the primary key balue of the record to be deleted
        Int32 UserId;
        //if a recrod has been selected from the list
        if (lstUserList.SelectedIndex != -1)
        {
            //get the primary key vaue of the record delete
            UserId = Convert.ToInt32(lstUserList.SelectedValue);
            //store the data in the session object
            Session["UserId"] = UserId;
            //redirect to the delete page
            Response.Redirect("UserManagementSystemConfirmDelete.aspx");

        }
        else // if no recrod has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsUserCollection AUser = new clsUserCollection();
        //retrieve the value of name from the presentation layer
        AUser.ReportByName(txtFilter.Text);
        //set the data source to the list of name in the collecton
        lstUserList.DataSource = AUser.UserList;
        //set the name of the primary key 
        lstUserList.DataValueField = "UserId";
        //set the name of the field to display
        lstUserList.DataTextField = "Name";
        //bind the data to the list
        lstUserList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the name object
        clsUserCollection AUser = new clsUserCollection();
        //set an empty string
        AUser.ReportByName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of users in the collection 
        lstUserList.DataSource = AUser.UserList;
        //set the name of the primary key
        lstUserList.DataValueField = "UserId";
        //set the anem of the filed to display
        lstUserList.DataTextField = "Name";
        //bind the data to the list
        lstUserList.DataBind();
    }


    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
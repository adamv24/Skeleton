using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of teh user to be processed
        UserId = Convert.ToInt32(Session["UserId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (UserId != -1)
            {
                //display the current data for the record
                DisplayUser();
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser AUser = new clsUser();
        //create a new instance of clsUser
        string Name = txtName.Text;
        string Role_Name = txtRoleName.Text;
        string Address = txtAddress.Text;
        string DateCreated = txtDateCreated.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Active = chkActive.Text;
        string Error = "";
        Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name);
        if (Error == "")
        {
            //capture the user id
            AUser.UserId = UserId; //dont miss this bit!!!!

            AUser.Name = Name;
            AUser.Role_Name = Role_Name;
            AUser.Address = Address;
            AUser.DateCreated = Convert.ToDateTime(DateCreated);
            AUser.PhoneNumber = PhoneNumber;
            AUser.IsActive = chkActive.Checked;

            clsUserCollection UserList = new clsUserCollection();

            //if this is a new record i.e. UserId = -1 then add the data
            if (UserId == -1)
            {
                //set the ThisUser property
                UserList.ThisUser = AUser;
                //add the new record
                UserList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the recrod to update
                UserList.ThisUser.Find(UserId);
                //set the ThisUser propertyu
                UserList.ThisUser = AUser;
                //update the record
                UserList.Update();

            }
            //redirect back toteh list page
            Response.Redirect("UserManagementSystemList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }









    }

    protected void btbFind_Click(object sender, EventArgs e)
    {
        //create an instance of the the stock class
        clsUser AUser = new clsUser();
        //create a variable to store the primary key
        Int32 UserId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary ket entered by the user
        UserId = Convert.ToInt32(txtUserId.Text);
        //find the record   
        Found = AUser.Find(UserId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtRoleName.Text = AUser.Role_Name;
            txtName.Text = AUser.Name.ToString();
            txtDateCreated.Text = AUser.DateCreated.ToString();
            txtPhoneNumber.Text = AUser.PhoneNumber.ToString();
            chkActive.Checked = AUser.IsActive;
            txtAddress.Text = AUser.Address;
        }
    }

    void DisplayUser()
    {
        //create an instance of the user book
        clsUserCollection UserBook = new clsUserCollection();
        //find the recrod to update
        UserBook.ThisUser.Find(UserId);
        //display the data for the record
        txtUserId.Text = UserBook.ThisUser.UserId.ToString();
        txtName.Text = UserBook.ThisUser.Name.ToString();
        txtPhoneNumber.Text = UserBook.ThisUser.PhoneNumber.ToString();
        txtAddress.Text = UserBook.ThisUser.Address.ToString();
        txtRoleName.Text = UserBook.ThisUser.Role_Name.ToString();
        chkActive.Checked = UserBook.ThisUser.IsActive;
        txtDateCreated.Text = UserBook.ThisUser.DateCreated.ToString();

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserManagementSystemList.aspx");
    }

}
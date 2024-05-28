using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser anUser = new clsUser();
        //create a new instance of clsUser
        string Name = txtName.Text;
        string Role_Name = txtRoleName.Text;
        string Address = txtAddress.Text;
        string DateCreated = txtDateCreated.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Active = chkActive.Text;
        string Error = "";
        Error = anUser.Valid(Name, Address, DateCreated, PhoneNumber, Active, Role_Name);
        if (Error == "")
        {
            anUser.Name = Name;
            anUser.Role_Name = Role_Name;
            anUser.Address = Address;
            anUser.DateCreated = Convert.ToDateTime(DateCreated);
            anUser.PhoneNumber = PhoneNumber;
            Session["anUser"] = anUser;
            Response.Redirect("UserManagementSystemViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        //capture the address
        anUser.Address = txtAddress.Text;
        //store the address in the session object
        Session["anUser"] = anUser;

        //capture the Name
        anUser.Name = txtName.Text;
        //store the address in the session object
        Session["anUser"] = anUser;

        //capture the UserId
        anUser.UserId = Convert.ToInt32(txtUserId.Text);
        //store the address in the session object
        Session["anUser"] = anUser;

        //capture the RoleId
        anUser.Role_Id = Convert.ToInt32(txtRoleId.Text);
        //store the address in the session object
        Session["anUser"] = anUser;

        //capture the Date Created
        anUser.DateCreated = Convert.ToDateTime(txtDateCreated.Text);
        //store the address in the session object
        Session["anUser"] = anUser;

        //capture the Role Name
        anUser.Role_Name = txtRoleName.Text;
        //store the address in the session object
        Session["anUser"] = anUser;


        //capture the Is Active
        anUser.IsActive = chkActive.Checked;
        //store the address in the session object
        Session["anUser"] = anUser;







        //Navigates to the view page
        Response.Redirect("UserManagementSystemViewer.aspx");

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
            txtRoleId.Text = AUser.Role_Id.ToString();
        }
    }
}
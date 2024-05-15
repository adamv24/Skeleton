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
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsUser
        clsUser AUser = new clsUser();

        //get the data from the session object
        AUser = (clsUser)Session["AUser"];
        //display the Address for this entry 
        Response.Write(AUser.Address);

        //display the Name for this entry 
        Response.Write(AUser.Name);

        //display the User Id for this entry 
        Response.Write(AUser.UserId);

        //display the phone number for this entry 
        Response.Write(AUser.PhoneNumber);

        //display the date created for this entry 
        Response.Write(AUser.DateCreated);

        //display the Role name for this entry 
        Response.Write(AUser.Role_Name);

        //display the is active for this entry 
        Response.Write(AUser.IsActive);






    }
}
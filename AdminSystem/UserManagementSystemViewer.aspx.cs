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
        clsUser anUser = new clsUser();

        //get the data from the session object
        anUser = (clsUser)Session["AnUser"];
        //display the Address for this entry 
        Response.Write(anUser.Address);

        //display the Name for this entry 
        Response.Write(anUser.Name);

        //display the User Id for this entry 
        Response.Write(anUser.UserId);

        //display the Role Id for this entry 
        Response.Write(anUser.Role_Id);

        //display the phone number for this entry 
        Response.Write(anUser.PhoneNumber);

        //display the date created for this entry 
        Response.Write(anUser.DateCreated);

        //display the Role name for this entry 
        Response.Write(anUser.Role_Name);

        //display the is active for this entry 
        Response.Write(anUser.IsActive);






    }
}
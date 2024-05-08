using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the house number for this entry
        Response.Write(AStock.BookName);

     
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the house number for this entry
        Response.Write(AStock.BookAuthor);

        AStock = (clsStock)Session["AStock"];
        //display the house number for this entry
        Response.Write(AStock.Price);
    }
}
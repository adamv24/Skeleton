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
        //create a new instance of clsAddress
        clsReview AnReview = new clsReview();

        //get the data from the session object
        AnReview = (clsReview)Session["AnReview"];

        //display the house number for this entry
        Response.Write("User Id = " + AnReview.UserId + "<br>");
        Response.Write("Book Id = " + AnReview.BookId + "<br>");
        Response.Write("Review Id = " + AnReview.ReviewId + "<br>");
        Response.Write("Review Text = " + AnReview.revText + "<br>");
        Response.Write("DateAdded = " + AnReview.DateAdded + "<br>");

    }
}
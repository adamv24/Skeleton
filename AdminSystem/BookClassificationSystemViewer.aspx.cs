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
        //create a new instance of clsAuthor
        clsAuthor AnAuthor = new clsAuthor();
        //get the data from the session object
        AnAuthor = (clsAuthor)Session["AnAuthor"];
        //display the author name for this entry
        Response.Write(AnAuthor.AuthorName);

        // Get the data from the session object again
        AnAuthor = (clsAuthor)Session["AnAuthor"];
        // Display the author biography
        Response.Write(AnAuthor.AuthorBiography);

        // Get the data from the session object again
        AnAuthor = (clsAuthor)Session["AnAuthor"];
        // Display the date joined
        Response.Write(AnAuthor.DateJoined);

        // Get the data from the session object again
        AnAuthor = (clsAuthor)Session["AnAuthor"];
        // Display if the author is a bestseller
        Response.Write(AnAuthor.IsBestSeller);

        // Get the data from the session object again
        AnAuthor = (clsAuthor)Session["AnAuthor"];
        // Display the average rating
        Response.Write(AnAuthor.AverageRating);

        // Get the data from the session object again
        AnAuthor = (clsAuthor)Session["AnAuthor"];
        // Display the total books sold
        Response.Write(AnAuthor.TotalBooksSold);
    }
}
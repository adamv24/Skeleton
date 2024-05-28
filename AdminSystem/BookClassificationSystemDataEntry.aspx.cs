using System;
using System.Activities.Expressions;
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
        {
            // Create a new instance of clsAuthor
            clsAuthor AnAuthor = new clsAuthor();

            // Capture the author name
            string AuthorName = txtAuthorName.Text;

            // Capture the author biography
            string AuthorBiography = txtAuthorBiography.Text;

            // Capture the date joined
            string DateJoined = txtDateJoined.Text;

            // Capture the is bestseller checkbox
            string IsBestSeller = chkIsBestseller.Checked.ToString();

            // Capture the average rating
            string AverageRating = txtAverageRating.Text;

            // Capture the total books sold
            string TotalBooksSold = txtTotalBooksSold.Text;

            // Variable to store any error messages
            string Error = "";

            // Validate the data
            Error = AnAuthor.Valid(AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);


            if (Error == "")
            {
                // Capture the author name
                AnAuthor.AuthorName = AuthorName;

                // Capture the author biography
                AnAuthor.AuthorBiography = AuthorBiography;

                // Capture the date joined
                AnAuthor.DateJoined = Convert.ToDateTime(DateJoined);

                // Capture the is bestseller checkbox
                AnAuthor.IsBestSeller = chkIsBestseller.Checked;

                // Capture the average rating
                AnAuthor.AverageRating = decimal.Parse(AverageRating);

                // Capture the total books sold
                AnAuthor.TotalBooksSold = Convert.ToInt32(TotalBooksSold);

                // Store the author in the session object
                Session["AnAuthor"] = AnAuthor;

                // Navigate to the view page
                Response.Redirect("BookClassificationSystemViewer.aspx");
            }
            else
            {
                // Display the error message
                lblError.Text = Error;
            }
           
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsAuthor
        clsAuthor AnAuthor = new clsAuthor();
        //create a variable to store the primary key
        Int32 AuthorId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AuthorId = Convert.ToInt32(txtAuthorId.Text);
        //find the record
        Found = AnAuthor.Find(AuthorId);
        //if found 
        if (Found == true)
        {
            // Display the values of the properties in the form
            txtAuthorName.Text = AnAuthor.AuthorName;
            txtAuthorBiography.Text = AnAuthor.AuthorBiography;
            txtDateJoined.Text = AnAuthor.DateJoined.ToString();
            chkIsBestseller.Checked = AnAuthor.IsBestSeller;
            txtAverageRating.Text = AnAuthor.AverageRating.ToString();
            txtTotalBooksSold.Text = AnAuthor.TotalBooksSold.ToString();
        }
    }
}
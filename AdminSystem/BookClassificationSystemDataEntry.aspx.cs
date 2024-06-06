using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 AuthorId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the author to be processed
        AuthorId = Convert.ToInt32(Session["AuthorId"]);
        if (IsPostBack == false)
        {
            // If this is not a new record
            if (AuthorId != -1)
            {
                // Display the current data for the record
                DisplayAuthor();
            }
        }
    }

    private void DisplayAuthor()
    {
        // Create an instance of the Author class
        clsAuthor AnAuthor = new clsAuthor();
        // Find the record to update
        AnAuthor.Find(AuthorId);
        // Display the data for this record
        txtAuthorId.Text = AnAuthor.AuthorId.ToString();
        txtAuthorName.Text = AnAuthor.AuthorName;
        txtAuthorBiography.Text = AnAuthor.AuthorBiography;
        txtDateJoined.Text = AnAuthor.DateJoined.ToString("yyyy-MM-dd");
        chkIsBestseller.Checked = AnAuthor.IsBestSeller;
        txtAverageRating.Text = AnAuthor.AverageRating.ToString();
        txtTotalBooksSold.Text = AnAuthor.TotalBooksSold.ToString();
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
                // Capture the author details
                AnAuthor.AuthorId = AuthorId;
                AnAuthor.AuthorName = AuthorName;
                AnAuthor.AuthorBiography = AuthorBiography;
                AnAuthor.DateJoined = Convert.ToDateTime(DateJoined);
                AnAuthor.IsBestSeller = chkIsBestseller.Checked;
                AnAuthor.AverageRating = Convert.ToDecimal(AverageRating);
                AnAuthor.TotalBooksSold = Convert.ToInt32(TotalBooksSold);

                // Create a new instance of the author collection
                clsAuthorCollection AuthorList = new clsAuthorCollection();

                // If this is a new record i.e., AuthorId = -1 then add the data
                if (AuthorId == -1)
                {
                    // Set the ThisAuthor property
                    AuthorList.ThisAuthor = AnAuthor;
                    // Add the new record
                    AuthorList.Add();
                }
                else
                {
                    // Otherwise, it must be an update
                    // Get the primary key value from the session object
                   
                    // Find the record to update
                    AuthorList.ThisAuthor.Find(AuthorId);
                    // Set the ThisAuthor property
                    AuthorList.ThisAuthor = AnAuthor;
                    // Update the record
                    AuthorList.Update();
                }

                // Redirect back to the list page
                Response.Redirect("BookClassificationSystemList.aspx");
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
        if (txtAuthorId.Text != "")
        {
            //get the primary key entered by the user
            AuthorId = Convert.ToInt32(txtAuthorId.Text);
            //find the record
            Found = AnAuthor.Find(AuthorId);

            //if found 
            if (Found)
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
        else
        {
            lblError.Text = "Enter an AuthorID to find";
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("BookClassificationSystemList.aspx");
    }
}
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
        {
            // Create a new instance of clsAuthor
            clsAuthor AnAuthor = new clsAuthor();
            // Capture the author name
            AnAuthor.AuthorName = txtAuthorName.Text;
            // Optionally update other properties as needed
            AnAuthor.AuthorBiography = txtAuthorBiography.Text;
            AnAuthor.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
            AnAuthor.IsBestSeller = chkIsBestseller.Checked;
            AnAuthor.AverageRating = decimal.Parse(txtAverageRating.Text);
            AnAuthor.TotalBooksSold = Convert .ToInt32(txtTotalBooksSold.Text);




            // Store the author in the session object
            Session["AnAuthor"] = AnAuthor;



            // Navigate to the view page
            Response.Redirect("BookClassificationSystemViewer.aspx");
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
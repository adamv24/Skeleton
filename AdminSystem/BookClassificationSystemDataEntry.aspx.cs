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
}
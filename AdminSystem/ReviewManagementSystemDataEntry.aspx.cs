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
    protected void Button1_Click(object sender, EventArgs e)
    {

        clsReview AnReview = new clsReview();

        AnReview.UserId = Convert.ToInt32(txtUser.Text);
        AnReview.BookId = Convert.ToInt32(txtBookId.Text);
        AnReview.ReviewId = Convert.ToInt32(txtReviewId.Text);
        AnReview.RatingId = Convert.ToInt32(txtReviewId.Text);
        AnReview.revText = txtReviewTextId.Text;
        AnReview.DateAdded = Convert.ToDateTime(txtDateAddedId.Text);




        Session["AnReview"] = AnReview;
        // navigater to the view page
        Response.Redirect("ReviewManagementSystemViewer.aspx");
    }

  

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtBookId_TextChanged(object sender, EventArgs e)
    {
        clsReview AnReview = new clsReview();
        Int32 UserId;
        Boolean Found = false;
        UserId = Convert.ToInt32(txtUser.Text);
        Found = AnReview.Find(UserId);

        if (Found == true)
        {
            txtBookId.Text = AnReview.BookId.ToString();
            txtRatingId.Text = AnReview.RatingId.ToString();
            txtReviewId.Text = AnReview.ReviewId.ToString();
            txtReviewTextId.Text = AnReview.Text.ToString();
            txtDateAddedId.Text = AnReview.DateAdded.ToString();

        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {

    }
}
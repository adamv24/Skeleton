using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToInt32(Session["UserId"]);
        if (IsPostBack == false)
        {
            if (UserId != -1)
            {
                DisplayAddress();
            }
            
        }

    }
    void DisplayAddress()
    {
        clsReviewCollection ReviewBook = new clsReviewCollection();
        ReviewBook.ThisReview.Find(UserId);
        txtUser.Text = ReviewBook.ThisReview.UserId.ToString();
        txtBookId.Text = ReviewBook.ThisReview.BookId.ToString();
        txtReviewId.Text = ReviewBook.ThisReview.ReviewId.ToString();
        txtRatingId.Text = ReviewBook.ThisReview.RatingId;
        txtReviewTextId.Text = ReviewBook.ThisReview.Text;
        txtDateAddedId.Text = ReviewBook.ThisReview.DateAdded.ToString();
        txtCheck.Text = ReviewBook.ThisReview.ReviewSubmitted;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        clsReview AnReview = new clsReview();

        int BookId = Convert.ToInt32(txtBookId.Text);
        int ReviewId = Convert.ToInt32(txtReviewId.Text);
        string RatingId = txtRatingId.Text;
        string ReviewText = txtReviewTextId.Text;
        string DateAdded = txtDateAddedId.Text;
        string ReviewSubmitted = txtCheck.Text;

        string Error = "";
        Error = AnReview.Valid(BookId, ReviewId, RatingId, ReviewText, DateAdded);
        if (Error == "")
        {
            AnReview.UserId = UserId;
            AnReview.BookId = BookId;
            AnReview.ReviewId = ReviewId;
            AnReview.RatingId = RatingId;
            AnReview.Text = ReviewText;
            AnReview.DateAdded = Convert.ToDateTime(DateAdded);
            AnReview.ReviewSubmitted = txtCheck.Text;
            clsReviewCollection ReviewList = new clsReviewCollection();

            if (UserId == -1)
            {
                ReviewList.ThisReview = AnReview;
                ReviewList.Add();
            }
            else
            {
                ReviewList.ThisReview.Find(UserId);
                ReviewList.ThisReview = AnReview;
                ReviewList.Update();
            }
            Session["AnReview"] = AnReview;

            // navigater to the view page
            Response.Redirect("ReviewManagementSystemList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
        clsReview AnReview = new clsReview();

        Int32 UserId;

        Boolean Found = false;

        UserId = Convert.ToInt32(txtUser.Text);

        Found = AnReview.Find(UserId);
        if (Found == true)
        {
            txtUser.Text = AnReview.UserId.ToString();
            txtBookId.Text = AnReview.BookId.ToString();
            txtReviewId.Text = AnReview.ReviewId.ToString();
            txtDateAddedId.Text = AnReview.DateAdded.ToString();
            txtReviewTextId.Text = AnReview.Text;
            txtRatingId.Text= AnReview.RatingId.ToString();
            txtCheck.Checked = AnReview.Active;
        }

    }
}
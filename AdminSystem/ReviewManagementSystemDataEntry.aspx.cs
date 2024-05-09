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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsReview AnReview = new clsReview();

        AnReview.Text = ReviewText.Text;

        AnReview.BookId = BooksId.BookId;

        Session["AnReview"] = AnReview;
         
        //navigater to the view page
        Response.Redirect("ReviewManagementSystemViewer.aspx");

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayReviews();
        }
    }

    void DisplayReviews()
    {
        clsReviewCollection Reviews = new clsReviewCollection();
        lstReviewList.DataSource = Reviews.ReviewList;
        lstReviewList.DataValueField = "UserId";
        lstReviewList.DataTextField = "Text";
        lstReviewList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["UserId"] = -1;
        Response.Redirect("ReviewManagementSystemDataEntry.aspx");
    }

    protected void lstReviewList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 UserId;
        if (lstReviewList.SelectedIndex != -1)
        {
            UserId = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["UserId"] = UserId;
            Response.Redirect("ReviewManagementSystemDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 UserId;
        if (lstReviewList.SelectedIndex != -1)
        {
            UserId = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["UserId"] = UserId;
            Response.Redirect("ReviewManagementSystemConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}
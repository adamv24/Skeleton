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
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayAuthors();
        }
    }

    void DisplayAuthors()
    {
        // create an instance of the Author collection
        clsAuthorCollection Authors = new clsAuthorCollection();
        // set the data source to the list of authors in the collection
        lstAuthorsList.DataSource = Authors.AuthorList;
        // set the name of the primary key
        lstAuthorsList.DataValueField = "AuthorId";
        // set the data field to display
        lstAuthorsList.DataTextField = "AuthorName";
        // bind the data to the list
        lstAuthorsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["AuthorId"] = -1;
        //redirect to the data entry page
        Response.Redirect("BookClassificationSystemDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited
        Int32 AuthorId;
        // If a record has been selected from the list
        if (lstAuthorsList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            AuthorId = Convert.ToInt32(lstAuthorsList.SelectedValue);
            // Store the data in the session object
            Session["AuthorId"] = AuthorId;
            // Redirect to the edit page
            Response.Redirect("BookClassificationSystemDataEntry.aspx");
        }
        else
        {
            // If no record has been selected
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be deleted
        Int32 AuthorId;
        // If a record has been selected from the list
        if (lstAuthorsList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to delete
            AuthorId = Convert.ToInt32(lstAuthorsList.SelectedValue);
            // Store the data in the session object
            Session["AuthorId"] = AuthorId;
            // Redirect to the delete page
            Response.Redirect("BookClassificationSystemConfirmDelete.aspx");
        }
        else
        {
            // If no record has been selected
            // Display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}
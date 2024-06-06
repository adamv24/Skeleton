using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 AuthorId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the author to be deleted from the session object
        AuthorId = Convert.ToInt32(Session["AuthorId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the author collection class
        clsAuthorCollection AuthorBook = new clsAuthorCollection();
        // Find the record to delete
        AuthorBook.ThisAuthor.Find(Convert.ToInt32(Session["AuthorId"]));
        // Delete the record
        AuthorBook.Delete();
        // Redirect back to the main page
        Response.Redirect(" BookClassificationSystemList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page
        Response.Redirect("BookClassificationSystemList.aspx");
    }
}
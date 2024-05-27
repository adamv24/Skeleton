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
}
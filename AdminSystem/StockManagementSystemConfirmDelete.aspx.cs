using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 IsbnId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        IsbnId = Convert.ToInt32(Session["IsbnId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection class
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(IsbnId);
        //delete the record
        StockBook.Delete();
        //redirect back the the main page
        Response.Redirect("StockManagementSystemList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockManagementSystemList.aspx");
    }
}
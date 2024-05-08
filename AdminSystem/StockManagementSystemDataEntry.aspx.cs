using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

        //capture the book name
        AStock.BookName = txtBookName.Text;
        //store the book name in the session object
        Session["AStock"] = AStock;
      
        //capture the book name
        AStock.BookAuthor = txtBookAuthor.Text;
        //store the book name in the session object
        Session["AStock"] = AStock;

        AStock.Price = Convert.ToDecimal(txtPrice.Text);
        //store the book name in the session object
        Session["AStock"] = AStock;

        //navigate to the view page
        Response.Redirect("StockManagementSystemViewer.aspx");
    }
}
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

        AStock.DateAdded = Convert.ToDateTime(DateTime.Now);
        //store the book name in the session object
        Session["AStock"] = AStock;

        AStock.QuantityAvailable = Convert.ToInt32(txtQuantityAvailable.Text);
        //store the book name in the session object
        Session["AStock"] = AStock;

        AStock.Active = chkIsAvailable.Checked;
        //store the book name in the session object
        Session["AStock"] = AStock;
        
        //navigate to the view page
        Response.Redirect("StockManagementSystemViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the the stock class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 IsbnId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary ket entered by the user
        IsbnId = Convert.ToInt32(txtIsbnID.Text);
        //find the record
        Found = AStock.Find(IsbnId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtBookName.Text = AStock.BookName;
            txtBookAuthor.Text = AStock.BookAuthor;
            txtPrice.Text = AStock.Price.ToString();
            txtDateAdded.Text = AStock.DateAdded.ToString();
            txtQuantityAvailable.Text = AStock.QuantityAvailable.ToString();
            chkIsAvailable.Checked = AStock.Active;
        }
    }
}
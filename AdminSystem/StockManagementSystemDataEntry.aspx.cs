using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 IsbnId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        IsbnId = Convert.ToInt32(Session["IsbnId"]);
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //id this is not a new record
            if (IsbnId != -1)
            {
                //update the current data for the record
                DisplayStocks();
            }
        }
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
        string BookName = txtBookName.Text;

        //capture the book name
        string BookAuthor = txtBookAuthor.Text;

        //capture the price
        string Price = txtPrice.Text;

        //capture the date added
        string DateAdded = txtDateAdded.Text;

        //capture the quantiity available
        string QuantityAvailable = txtQuantityAvailable.Text;

        //capture if book is available
        string Active = chkIsAvailable.Text;



        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
        if (Error == "")
        {
            //capture the isbn id
            AStock.IsbnID = IsbnId; //DON'T MISS THIS BIT !!!!!
            //capture the book name
            AStock.BookName = BookName;
            //capture the authors name
            AStock.BookAuthor = BookAuthor;
            //capture the price
            AStock.Price = Convert.ToDecimal(Price);
            //capture the date added
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            //capture the quantity available
            AStock.QuantityAvailable = Convert.ToInt32(QuantityAvailable);
            //capture active
            AStock.Active = chkIsAvailable.Checked;
            //create a new instance of the adress collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. StockId = -1 then add the data
            if (IsbnId == -1)
            {
                //set the ThisAdress property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }

            //otherwise it must be an update
            else
            {
                //find te record to be an update
                StockList.ThisStock.Find(IsbnId);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockManagementSystemList.aspx");

        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

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

    void DisplayStocks()
    {
        //create an instance of the stock book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(IsbnId);
        //display the data for the record
        txtIsbnID.Text = StockBook.ThisStock.IsbnID.ToString();
        txtBookName.Text = StockBook.ThisStock.BookName.ToString();
        txtBookAuthor.Text = StockBook.ThisStock.BookAuthor.ToString();
        txtPrice.Text = StockBook.ThisStock.Price.ToString();
        txtDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        txtQuantityAvailable.Text = StockBook.ThisStock.QuantityAvailable.ToString();
        chkIsAvailable.Checked = StockBook.ThisStock.Active;

    }
}
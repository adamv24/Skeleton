﻿using ClassLibrary;
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
            //set the ThisStock property
            StockList.ThisStock = AStock;
            //add the new record
            StockList.Add();
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
}
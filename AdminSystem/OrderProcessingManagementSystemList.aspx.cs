﻿ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing4;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrder();
        }
        //create a new instance of clsStockUser
        clsStockUser AnUser = new clsStockUser();
        //get the data from the session object
        AnUser = (clsStockUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayOrder()
    {
        //create an instance of the stock collection
        clsOrderCollection order = new clsOrderCollection();
        //set the data source to the list of addressin the collection
        lstOrderList.DataSource = order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "ISBN";
        
        //bind the data to the list
        lstOrderList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Order_Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderProcessingManagementSystemDataEntry.aspx");
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //varaiable to store the primary key balue of the record to be deleted
        Int32 Order_id;
        //if a recrod has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key vaue of the record delete
             Order_id = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["Order_Id"] = Order_id;
            //redirect to the delete page
            Response.Redirect("OrderProcessingManagementSystemConfirmDelete.aspx");
        }
        else // if no recrod has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderId;
        //if the record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["Order_Id"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrderProcessingManagementSystemDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }

    }
    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsOrderCollection anOrder = new clsOrderCollection();
        //retrieve the value of the book name from the presentation layer
        anOrder.ReportByStatus(txtFilter.Text);
        //set the data source to the list of stocks in the collection
        lstOrderList.DataSource = anOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "ISBN";
       
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsOrderCollection anOrder = new clsOrderCollection();
        //set an empty string
        anOrder.ReportByStatus("");
        //clear any existin filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of stocks in the collection
        lstOrderList.DataSource = anOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "Order_Id";
        lstOrderList.DataTextField = "ISBN";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }

    protected void btnApplyFilter_Click1(object sender, EventArgs e)
    {

    }

    protected void btnClearFilter_Click1(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsOrderCollection anOrder = new clsOrderCollection();
        //set an empty string
        anOrder.ReportByStatus("");
        //clear any existin filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of stocks in the collection
        lstOrderList.DataSource = anOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "ISBN";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    
}
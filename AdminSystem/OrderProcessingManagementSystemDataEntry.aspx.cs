using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Testing4;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        OrderId = Convert.ToInt32(Session["Order_Id"]);
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //id this is not a new record
            if (OrderId != -1)
            {
                //update the current data for the record
                DisplayOrders();
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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //capture the isbn
        string isbn = txtISBN.Text;

        //capture the status
        string status = txtStatus.Text;

        //capture the user id
        string userId = txtUserId.Text;

        //capture the created at
        DateTime created = DateTime.Now;

        //capture if order is valid
    

        //variable to store any error messages
        string Error = "";

        //validate the data
        // Error = AnOrder.Valid(isbn, userId, isValid, created, status);

        if (Error == "")
        {
            //set the properties of the AnOrder object
            AnOrder.ISBN = Convert.ToInt32(isbn);
            AnOrder.UserId = Convert.ToInt32(userId);
           
            AnOrder.CreatedAt = created;
            AnOrder.Status = status;

            //create a new instance of the clsOrder collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //add the new record
            OrderList.ThisOrder = AnOrder;
            int OrderId = OrderList.Add();

            //redirect back to the list page
            Response.Redirect("OrderProcessingManagementSystemList.aspx");
        }
        else
        {
            //display the error message
            lblStatusValue.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        {
            // Create an instance of clsOrder
            ClassLibrary.clsOrder order = new ClassLibrary.clsOrder();

            // Create a variable to store the primary key
            Int32 OrderId;

            // Create a variable to store the result of the find operation
            Boolean Found = false;

            // Get the primary key entered by the user
            OrderId = Convert.ToInt32(txtOrderId.Text);

            // Find the record
            Found = order.Find(OrderId);
            string error = order.Valid(order.ISBN.ToString(), order.UserId.ToString(), order.CreatedAt.ToString(), order.Status);


            // If found
            if (error==""||Found==true)
            {
                // Display the values of the properties in the form
                txtISBN.Text = order.ISBN.ToString();
                txtUserId.Text = order.UserId.ToString();
                txtStatus.Text = order.Status;
            }
            else
            {
                // If the order was not found, handle it here
                lblStatusValue.Text = "Order not found";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderProcessingManagementSystemList.aspx");
    }

    void DisplayOrders()
    {
        //create an instance of the stock book
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to update
        Order.ThisOrder.Find(OrderId);
        //display the data for the record
        txtOrderId.Text = Order.ThisOrder.OrderId.ToString();
        txtISBN.Text = Order.ThisOrder.ISBN.ToString();
        txtUserId.Text = Order.ThisOrder.UserId.ToString();
        txtCreatedAt.Text = Order.ThisOrder.CreatedAt.ToString();
        txtStatus.Text = Order.ThisOrder.Status.ToString();
        chkIsAvailable.Checked = Order.ThisOrder.IsValid;


    }
}

      
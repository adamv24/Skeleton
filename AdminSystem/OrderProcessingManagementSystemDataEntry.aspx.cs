using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Protocols.WSTrust;
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

    protected void Button1_Click(object sender, EventArgs e)
    {

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
            if (error=="")
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
}

      
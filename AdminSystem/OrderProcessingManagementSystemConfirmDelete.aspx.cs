using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Testing4;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Order_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
         Order_Id = Convert.ToInt32(Session["Order_Id"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection class
        clsOrderCollection OrderList = new clsOrderCollection();
        //find the record to delete
        OrderList.ThisOrder.Find(Order_Id);
        //delete the record
        OrderList.Delete();
        //redirect back the the main page
        Response.Redirect("OrderProcessingManagementSystemList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderProcessingManagementSystemList.aspx");
    }
}
using ClassLibrary;
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
}
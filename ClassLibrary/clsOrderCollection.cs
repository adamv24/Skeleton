using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Testing4
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        {
             Int32 index = 0;
             Int32 recordCount = 0;
             clsDataConnection db = new clsDataConnection();
             db.Execute("sproc_tblOrder_SelectAll");
             recordCount = db.Count;
             while (index < recordCount)
             {
                 clsOrder anOrder = new clsOrder();
                 anOrder.ISBN = Convert.ToInt32(db.DataTable.Rows[index]["ISBN"]);
                 anOrder.Status = Convert.ToString(db.DataTable.Rows[index]["Status"]);
                 anOrder.IsValid = Convert.ToBoolean(db.DataTable.Rows[index]["IsValid"]);
                 anOrder.OrderId = Convert.ToInt32(db.DataTable.Rows[index]["OrderId"]);
                 anOrder.UserId = Convert.ToInt32(db.DataTable.Rows[index]["UserId"]);
                 anOrder.CreatedAt = Convert.ToDateTime(db.DataTable.Rows[index]["CreatedAt"]);
                 mOrderList.Add(anOrder);
                 index++;
            }
            
        }



        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private member data for thisStock
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }

            set
            {
                //yee
            }

        }


        //public property for ThisStock
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

    }
}
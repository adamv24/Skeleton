using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Testing4
{
    public class clsOrderCollection
    {

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

        public clsOrderCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        public int Add()
        {
            //adds a record to the database based on the the valuess of the mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@ISBN", mThisOrder.ISBN);
            DB.AddParameter("@User_Id", mThisOrder.UserId);
            DB.AddParameter("@Is_Valid", mThisOrder.IsValid);
            DB.AddParameter("@Created_At", mThisOrder.CreatedAt);
            DB.AddParameter("@Status", mThisOrder.Status);



            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@ISBN", mThisOrder.ISBN);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@Is_Valid", mThisOrder.IsValid);
            DB.AddParameter("@Created_At", mThisOrder.CreatedAt);
            DB.AddParameter("@User_Id", mThisOrder.UserId);
            DB.AddParameter("@Order_Id", mThisOrder.OrderId);

            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }
        public void Delete()
        {
            //delete the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Order_Id", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }



        public void ReportByStatus(string Status)
        {
            //filter the records based on a full or partial book name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the BookName parameter to the database
            DB.AddParameter("@Status", Status);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByStatus");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection db)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = db.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (index < RecordCount)
            {
                //creat a blank stock object
                clsOrder anOrder = new clsOrder();
                //read in the fields from the current record
                anOrder.ISBN = Convert.ToInt32(db.DataTable.Rows[index]["ISBN"]);
                anOrder.Status = Convert.ToString(db.DataTable.Rows[index]["Status"]);
                anOrder.IsValid = Convert.ToBoolean(db.DataTable.Rows[index]["Is_Valid"]);
                anOrder.OrderId = Convert.ToInt32(db.DataTable.Rows[index]["Order_Id"]);
                anOrder.UserId = Convert.ToInt32(db.DataTable.Rows[index]["User_Id"]);
                anOrder.CreatedAt = Convert.ToDateTime(db.DataTable.Rows[index]["Created_At"]);
                //add the record to the private data member
                mOrderList.Add(anOrder);
                //point at the next record
                index++;
            }
        }
    }
}
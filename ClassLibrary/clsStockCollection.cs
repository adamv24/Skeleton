using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for thisStock
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set { 
                //set the private data
                mStockList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }

            set
            {
                //we shall worry about this later
            }

        }


        //public property for ThisStock
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        
        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record the count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are recirds to process
            while (Index < RecordCount)
            {
                //create the blank stock
                clsStock AStock = new clsStock();
                //read in the fields for the current records
                AStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAvailable"]);
                AStock.IsbnID = Convert.ToInt32(DB.DataTable.Rows[Index]["IsbnId"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStock.BookName = Convert.ToString(DB.DataTable.Rows[Index]["BookName"]);
                AStock.BookAuthor = Convert.ToString(DB.DataTable.Rows[Index]["BookAuthor"]);
                AStock.QuantityAvailable = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityAvailable"]);
                AStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);

                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next records
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the the valuess of the mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@BookName", mThisStock.BookName);
            DB.AddParameter("@BookAuthor", mThisStock.BookAuthor);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@QuantityAvailable", mThisStock.QuantityAvailable);
            DB.AddParameter("@IsAvailable", mThisStock.Active);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }
    }
}
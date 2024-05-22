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
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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

        public void Update()
        {
            //update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@IsbnId", mThisStock.IsbnID);
            DB.AddParameter("@BookName", mThisStock.BookName);
            DB.AddParameter("@BookAuthor", mThisStock.BookAuthor);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@QuantityAvailable", mThisStock.QuantityAvailable);
            DB.AddParameter("@IsAvailable", mThisStock.Active);

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@IsbnId", mThisStock.IsbnID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByBookName(string BookName)
        {
            //filter the records based on a full or partial book name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //senf the BookName parameter to the database
            DB.AddParameter("@BookName", BookName);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByBookName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to processs
            while (Index < RecordCount)
            {
                //creat a blank stock object
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAvailable"]);
                AStock.IsbnID = Convert.ToInt32(DB.DataTable.Rows[Index]["IsbnId"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStock.BookName = Convert.ToString(DB.DataTable.Rows[Index]["BookName"]);
                AStock.BookAuthor = Convert.ToString(DB.DataTable.Rows[Index]["BookAuthor"]);
                AStock.QuantityAvailable = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityAvailable"]);
                AStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;

            }
        }

    }

    
}
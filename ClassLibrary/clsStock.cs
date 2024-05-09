using System;
using System.Diagnostics.Eventing.Reader;

namespace ClassLibrary
{
    public class clsStock
    {
        //ACTIVE
        //private data member for the active property
        private Boolean mActive;
        //active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        //DATETIME
        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //ISBN ID
        //private data member for the address id property
        private Int32 mIsbnID;

        //addressId public property
        public int IsbnID
        {
            get
            {
                //this line of code sends data out of the property
                return mIsbnID;
            }
            set
            {
                //this line of code allows data into the property
                mIsbnID = value;
            }
        }

        //BOOK NAME
        //private data member for the town property
        private string mBookName;
        //town public property
        public string BookName
        {
            get
            {
                //this line of code sends data out of the property
                return mBookName;
            }
            set
            {
                //this line of code allows data into the property
                mBookName = value;
            }
        }

        //BOOK AUTHOR
        //private data member for the town property
        private string mBookAuthor;
        public string BookAuthor
        {
            get
            {
                //this line of code sends data out of the property
                return mBookAuthor;
            }
            set
            {
                //this line of code allows data into the property
                mBookAuthor = value;
            }
        }

        //QUANTITY AVAILABLE
        //private data member for the address id property
        private Int32 mQuantityAvailable;

        //addressId public property
        public int QuantityAvailable
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantityAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mQuantityAvailable = value;
            }
        }

        //PRICE
        //private data member for the address id property
        private Decimal mPrice;

        //addressId public property
        public Decimal Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }


        //Find method
        public bool Find(int isbnId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@IsbnId", isbnId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByIsbnID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mIsbnID = Convert.ToInt32(DB.DataTable.Rows[0]["IsbnId"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mBookName = Convert.ToString(DB.DataTable.Rows[0]["BookName"]);
                mBookAuthor = Convert.ToString(DB.DataTable.Rows[0]["BookAuthor"]);
                mQuantityAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityAvailable"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);

                //return that everything worked Ok
                return true;
            }
            //if no record was found
            else
            {
               //return false indicating there is a problem
               return false;
            }
 
        }
    }
}
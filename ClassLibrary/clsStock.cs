using System;

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
        public decimal Price { get; set; }


        //Find method
        public bool Find(int isbnId)
        {
            //set the private data members to the test value
            mIsbnID = 21;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mActive = true;
            mBookName = "Book Name";
            mBookAuthor = "Book Author";
            mQuantityAvailable = 3;

            //always return true
            return true;
        }
    }
}
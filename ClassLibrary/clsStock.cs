using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;

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

        public string Valid(string bookName, string bookAuthor, string price, string dateAdded, string quantityAvailable)
        {
            //create a string variable to store the error
            String Error = "";

            //VALIDATION FOR DATEADDED
            //create an instance of DateTime to compare with DateTemp
            //in the if statement
            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);


                if (DateTemp < DateComp)//compare the dateAdded with Date
                {
                    Error = Error + "The date cannot be in the past: ";
                }

                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }

            //VALIDATION FOR BOOK NAME
            //is the bookName blank
            if (bookName.Length == 0)
            {
                //record the error
                Error = Error + "The book name may not be blank : ";
            }
            //if the BookName is too long
            if (bookName.Length > 50)
            {
                //record the error
                Error = Error + "The book name must be less than 50 characters : ";
            }

            //VALIDATION FOR BOOK AUTHOR
            //is the bookAuthor blank
            if (bookAuthor.Length == 0)
            {
                //record the error
                Error = Error + "The authors name may not be blank : ";
            }
            //if the town is too long
            if (bookAuthor.Length > 50)
            {
                //record the error
                Error = Error + "The authors name must be less than 50 characters : ";
            }

            //VALIDATION FOR QUANTITY AVAILABLE
            // Check if the quantityAvailableStr is not null or empty
            if (string.IsNullOrEmpty(quantityAvailable))
            {
                // Record the error
                Error = Error + "The quantity available must not be empty : ";
            }
            else
            {
                
                try
                {
                    //convert string to int
                    int quantityAvailableInt = Convert.ToInt32(quantityAvailable);

                    // Check if the quantityAvailable is negative
                    if (quantityAvailableInt < 0)
                    {
                        // Record the error
                        Error = Error + "The quantity available cannot be less than 0 : ";
                    }
                }
                catch (FormatException)
                {
                    // Record the error if quantityAvailableInt cannot be converted to an integer
                    Error = Error + "The quantity available must be an number : ";
                }
            }


            //reuturn any error messages
            return Error;



           
        }
    }
}
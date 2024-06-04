using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderId;
        //OrderId public property
        public int OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }
        //private data member for the order id property
        private bool mIsValid;
        //OrderId public property
        public bool IsValid
        {
            get
            {
                // Return the value of the private data member mIsBestSeller
                return mIsValid;
            }
            set
            {
                // Set the value of the private data member mIsBestSeller
                mIsValid = value;
            }
        }
        //private data member for the ISBN property
        private Int32 mISBN;
        //ISBN public property
        public int ISBN
        {
            get
            {
                //this line of code sends data out of the property
                return mISBN;
            }
            set
            {
                //this line of code allows data into the property
                mISBN = value;
            }
        }

        //private data member for the user id property
        private Int32 mUserId;
        //UserId public property
        public int UserId
        {
            get
            {
                //this line of code sends data out of the property
                return mUserId;
            }
            set
            {
                //this line of code allows data into the property
                mUserId = value;
            }
        }

        //private data member for the created at property
        private DateTime? mCreatedAt;
        //CreatedAt public property
        public DateTime? CreatedAt
        {
            get
            {
                //this line of code sends data out of the property
                return mCreatedAt;
            }
            set
            {
                //this line of code allows data into the property
                mCreatedAt = value;
            }
        }

        //private data member for the status property
        private string mStatus;
        //Status public property
        public string Status
        {
            get
            {
                //this line of code sends data out of the property
                return mStatus;
            }
            set
            {
                //this line of code allows data into the property
                mStatus = value;
            }
        }

        /****** FIND METHOD ******/
        public bool Find(int OrderId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the ISBN ID to search for
            DB.AddParameter("@OrderId", OrderId);
            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_FindById");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Id"]);
                mISBN = Convert.ToInt32(DB.DataTable.Rows[0]["ISBN"]);
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["User_Id"]);
                mStatus = Convert.ToString(DB.DataTable.Rows[0]["Status"]);

                // Return that everything worked OK
                return true;
            }
            else
            {

                return false;
            }
        }



        public string Valid(string ISBN, string User_Id, string Created_At, string Status)
        {
            string error = "";

            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Created_At);


                if (DateTemp < DateComp)//compare the dateAdded with Date
                {
                    error = error + "The date cannot be in the past: ";
                }

                //check to see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    error = error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                error = error + "The date was not a valid date";
            }



            //VALIDATION FOR BOOK AUTHOR
            //is the bookAuthor blank
            if (Status.Length == 0)
            {
                //record the error
                error = error + "The authors name may not be blank : ";
            }
            //if the town is too long
            if (Status.Length > 50)
            {
                //record the error
                error = error + "The authors name must be less than 50 characters : ";
            }

            //USER_ID//
            if (string.IsNullOrEmpty(User_Id))
            {
                // Record the error
                error = error + "The quantity available must not be empty : ";
            }
            else
            {

                try
                {

                    //convert string to int
                    long ISBNAvailableInt = Convert.ToInt64(User_Id);

                    // Check if the quantityAvailable is negative
                    if (ISBNAvailableInt < 0)
                    {
                        // Record the error
                        error = error + "The ISBN available cannot be less than 0 : ";
                    }

                    // Check if the quantityAvailable is negative
                    if (ISBNAvailableInt > 2147483647)
                    {
                        // Record the error
                        error = error + "The ISBN available cannot be more than 2147483647 : ";
                    }
                }
                catch (FormatException)
                {
                    // Record the error if quantityAvailableInt cannot be converted to an integer
                    error = error + "The ISBN available must be a number : ";
                }
            }



            //VALIDATION FOR ISBN AVAILABLE
            // Check if the ISBN is not null or empty
            if (string.IsNullOrEmpty(ISBN))
            {
                // Record the error
                error = error + "The quantity available must not be empty : ";
            }
            else
            {

                try
                {

                    //convert string to int
                    long ISBNAvailableInt = Convert.ToInt64(ISBN);

                    // Check if the quantityAvailable is negative
                    if (ISBNAvailableInt < 0)
                    {
                        // Record the error
                        error = error + "The ISBN available cannot be less than 0 : ";
                    }

                    // Check if the quantityAvailable is negative
                    if (ISBNAvailableInt > 2147483647)
                    {
                        // Record the error
                        error = error + "The ISBN available cannot be more than 2147483647 : ";
                    }
                }
                catch (FormatException)
                {
                    // Record the error if quantityAvailableInt cannot be converted to an integer
                    error = error + "The ISBN available must be a number : ";
                }
            }
            return error;
        }
    }
}

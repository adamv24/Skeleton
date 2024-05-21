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
            return "";
        }
    }
}
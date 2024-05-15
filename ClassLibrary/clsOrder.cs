// clsOrder.cs
using System;

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
        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 21;
            mISBN = 123456;
            mUserId = 100;
            mCreatedAt = DateTime.Now;
            mStatus = "Started";

            //always return true
            return true;
        }
    }
}
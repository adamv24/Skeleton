using System;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public class clsUser
    {
        //private data memeber for the address id property
        private Int32 mUserId;
        private DateTime mDateCreated;
        private bool mIsActive;
        private string mAddress;
        private string mName;
        private string mPhoneNumber;
        private string mRole_Name;

        public Int32 UserId
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
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }
        public String PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }
        public string Address
        {
            get
            {
                //this line of code allows data into the property
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public DateTime DateCreated
        {
            get
            {
                return mDateCreated;
            }
            set
            {
                mDateCreated = value;
            }
        }
        public bool IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
            }
        }

        public string Role_Name
        {
            get
            {
                return mRole_Name;
            }
            set
            {
                mRole_Name = value;
            }
        }

        public int Count { get; set; }

        public bool Find(int userId)
        {
            //create an insttance of the data connecton
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@UserId", userId);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_FilterByUserId2");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mRole_Name = Convert.ToString(DB.DataTable.Rows[0]["RoleName"]);
                return true;

            }
            //if no record was foundelseelse
            else
            {
                return false;
            }
        }

        

        //DateCreated, Address, Name, PhoneNumber, Role_Name

        public string Valid(string dateCreated, string address, string name, string phoneNumber, string role_Name)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;


            if (string.IsNullOrEmpty(phoneNumber))
            {
                //record the error
                Error = Error + "The phone number no may not be blank : ";
            }
            else
            {
                //if the phone number is greater than 16 characters
                if (phoneNumber.Length < 10)
                {
                    Error = Error + "The phone number be at least 10 numbers : ";
                }
                if (phoneNumber.Length > 16)
                {
                    //record the error
                    Error = Error + "The phone number must be less than 16 characters : ";
                }
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateCreated);


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


            //if the post code is too long
            if (address.Length > 10)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the post code blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }


            //if the HouseNo is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The name must be less than 50 characters : ";
            }

            //is the role name blank
            if (role_Name.Length == 0)
            {
                //record the error
                Error = Error + "The role name may not be blank : ";
            }
            //if the role name is too long
            if (role_Name.Length > 50)
            {
                //record the error
                Error = Error + "The role name must be less than 50 characters : ";
            }

            //return any error messages
            return Error;
        }
    }
}
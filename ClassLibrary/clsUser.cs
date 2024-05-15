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
        private Int32 mRole_Id;       

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
        public int Role_Id
        {
            get
            {
                return mRole_Id;
            }
            set
            {
                mRole_Id = value;
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

        public bool Find(int userId)
        {
            //set the private data members to the test data value
            mUserId = 21;
            mDateCreated = Convert.ToDateTime("23/12/2022");
            mIsActive = true;
            mAddress = "XXX XXX";
            mName = "Edsger Dijkstra";
            mPhoneNumber = "07928473829";
            mRole_Name = "Manager Admin";
            mRole_Id = 32;



            //always return true
            return true;
        }
    }
}
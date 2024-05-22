using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public int UserID
        {
            get
            {
                //return private data member
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
            }
        }


        public string UserName {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }


        public string Password {
            get
            {
                return mPassword;
            }
            set 
            { 
                mPassword = value; 
            }
        }
        public string Department 
        {
            get
            {
                return mDepartment;
            }
            set
            { 
                mDepartment = value;
            }
        }

        public bool FindUser(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
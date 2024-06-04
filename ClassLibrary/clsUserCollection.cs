using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsUserCollection
    {
        //private data member for the list
        List<clsUser> mUserList = new List<clsUser>();
        //private member data for thisUser
        clsUser mThisUser = new clsUser();

        public List<clsUser> UserList
        {
            get
            {
                //return the private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }
        public int Count
        {
            get
            {
                //retrun the count of the list
                return mUserList.Count;
            }
            set
            {
                //LATER
            }
        }
        public clsUser ThisUser
        {
            get
            {
                //retrurn the private data
                return mThisUser;
            }
            set
            {
                //set the private data
                mThisUser = value;
            }
        }

        public clsUserCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection db = new clsDataConnection();
            db.Execute("sproc_tblUser_SelectAll");
            recordCount = db.Count;
            while (index < recordCount)
            {
                clsUser AUser = new clsUser();

                AUser.UserId = Convert.ToInt32(db.DataTable.Rows[index]["UserId"]);
                AUser.Name = Convert.ToString(db.DataTable.Rows[index]["Name"]);
                AUser.PhoneNumber = Convert.ToString(db.DataTable.Rows[index]["PhoneNumber"]);
                AUser.Address = Convert.ToString(db.DataTable.Rows[index]["Address"]);
                AUser.DateCreated = Convert.ToDateTime(db.DataTable.Rows[index]["DateCreated"]);
                AUser.IsActive = Convert.ToBoolean(db.DataTable.Rows[index]["IsActive"]);
                AUser.Role_Name = Convert.ToString(db.DataTable.Rows[index]["RoleName"]);

                mUserList.Add(AUser);
                index++;
            }
  
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserId", mThisUser.UserId);
            DB.AddParameter("@Name", mThisUser.Name);
            DB.AddParameter("@PhoneNumber", mThisUser.PhoneNumber);
            DB.AddParameter("@Address", mThisUser.Address);
            DB.AddParameter("@DateCreated", mThisUser.DateCreated);
            DB.AddParameter("@IsActive", mThisUser.IsActive);
            DB.AddParameter("@RoleName", mThisUser.Role_Name);

            //execture the query returning the primary key value
            return DB.Execute("Ssproc_tblUser_Insert");






        }
    }
}
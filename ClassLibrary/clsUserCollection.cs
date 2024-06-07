using System;
using System.Collections.Generic;
using System.Reflection;
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

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblUser_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);


        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisUser.Name);
            DB.AddParameter("@PhoneNumber", mThisUser.PhoneNumber);
            DB.AddParameter("@Address", mThisUser.Address);
            DB.AddParameter("@DateCreated", mThisUser.DateCreated);
            DB.AddParameter("@IsActive", mThisUser.IsActive);
            DB.AddParameter("@RoleName", mThisUser.Role_Name);

            //execture the query returning the primary key value
            return DB.Execute("sproc_tblUser_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisUser
            //connect to teh databse
            clsDataConnection DB = new clsDataConnection();
            //set the paramters fro the new stored procedure
            DB.AddParameter("@UserId", mThisUser.UserId);
            DB.AddParameter("@Name", mThisUser.Name);
            DB.AddParameter("@PhoneNumber", mThisUser.PhoneNumber);
            DB.AddParameter("@Address", mThisUser.Address);
            DB.AddParameter("@DateCreated", mThisUser.DateCreated);
            DB.AddParameter("@IsActive", mThisUser.IsActive);
            DB.AddParameter("@RoleName", mThisUser.Role_Name);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_Update");
        }

        public void Delete()
        {
            //dektes the record pointed to by thisUser
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored prodcude
            DB.AddParameter("@UserId", mThisUser.UserId);
            //ececture the stored procedure
            DB.Execute("sproc_tblUser_Delete");


        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name paramter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mUserList = new List<clsUser>();
            //WHILE THERE ARE RECORDS TO PROCESS
            while (Index < RecordCount)
            {
                clsUser AUser = new clsUser();

                AUser.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["UserId"]);
                AUser.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AUser.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AUser.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AUser.DateCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateCreated"]);
                AUser.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                AUser.Role_Name = Convert.ToString(DB.DataTable.Rows[Index]["RoleName"]);

                mUserList.Add(AUser);
                Index++;
            }
        }
    }
}
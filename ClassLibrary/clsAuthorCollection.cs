using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;


namespace ClassLibrary
{
    public class clsAuthorCollection
    {
        // Private data member for the list
        List<clsAuthor> mAuthorList = new List<clsAuthor>();
        // Private member data for thisAuthor
        clsAuthor mThisAuthor = new clsAuthor();

        // Public property for the author list
        public List<clsAuthor> AuthorList
        {
            get
            {
                // Return the private data
                return mAuthorList;
            }
            set
            {
                // Set the private data
                mAuthorList = value;
            }
        }

        // Public property for count
        public int Count
        {
            get
            {
                // Return the count of the list
                return mAuthorList.Count;
            }
            set
            {
                // We shall worry about this later
            }
        }

        // Public property for ThisAuthor
        public clsAuthor ThisAuthor
        {
            get
            {
                // Return the private data
                return mThisAuthor;
            }
            set
            {
                // Set the private data
                mThisAuthor = value;
            }
        }


        // Constructor for the class
        // Constructor for the class
        public clsAuthorCollection()
        {
            // Object for data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblAuthor_SelectAll");
            // Populate the array list with the data table
            PopulateArray(DB);
        }


        public int Add()
        {
            // Adds a record to the database based on the values of mThisAuthor
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@AuthorName", mThisAuthor.AuthorName);
            DB.AddParameter("@AuthorBiography", mThisAuthor.AuthorBiography);
            DB.AddParameter("@DateJoined", mThisAuthor.DateJoined);
            DB.AddParameter("@IsBestseller", mThisAuthor.IsBestSeller);
            DB.AddParameter("@AverageRating", mThisAuthor.AverageRating);
            DB.AddParameter("@TotalBooksSold", mThisAuthor.TotalBooksSold);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblAuthor_Insert");
        }

        public void Update()
        {
            // Update an existing record based on the values of ThisAuthor
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@AuthorId", mThisAuthor.AuthorId);
            DB.AddParameter("@AuthorName", mThisAuthor.AuthorName);
            DB.AddParameter("@AuthorBiography", mThisAuthor.AuthorBiography);
            DB.AddParameter("@DateJoined", mThisAuthor.DateJoined);
            DB.AddParameter("@IsBestseller", mThisAuthor.IsBestSeller);
            DB.AddParameter("@AverageRating", mThisAuthor.AverageRating);
            DB.AddParameter("@TotalBooksSold", mThisAuthor.TotalBooksSold);
            // Execute the stored procedure
            DB.Execute("sproc_tblAuthor_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AuthorId", mThisAuthor.AuthorId);
            DB.Execute("sproc_tblAuthor_Delete");
        }

        public void ReportByAuthorName(string AuthorName)
        {
            // Create a new instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the author name
            DB.AddParameter("@AuthorName", AuthorName);
            // Execute the stored procedure
            DB.Execute("sproc_tblAuthor_FilterByAuthorName");
            // Populate the author list
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Populates the array list based on the data table in the parameter DB
            // Variable for the index
            Int32 Index = 0;
            // Variable to store the record count
            Int32 RecordCount;
            // Get the count of records
            RecordCount = DB.Count;
            // Clear the private array list
            mAuthorList = new List<clsAuthor>();
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank author object
                clsAuthor AnAuthor = new clsAuthor();
                // Read in the fields from the current record
                AnAuthor.AuthorId = Convert.ToInt32(DB.DataTable.Rows[Index]["AuthorId"]);
                AnAuthor.AuthorName = Convert.ToString(DB.DataTable.Rows[Index]["AuthorName"]);
                AnAuthor.AuthorBiography = Convert.ToString(DB.DataTable.Rows[Index]["AuthorBiography"]);
                AnAuthor.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                AnAuthor.IsBestSeller = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsBestseller"]);
                AnAuthor.AverageRating = Convert.ToDecimal(DB.DataTable.Rows[Index]["AverageRating"]);
                AnAuthor.TotalBooksSold = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalBooksSold"]);
                // Add the record to the private data member
                mAuthorList.Add(AnAuthor);
                // Point at the next record
                Index++;
            }
        }
    }
}

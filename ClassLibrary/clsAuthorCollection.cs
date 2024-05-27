using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsAuthorCollection
    {
        // Private data member for the list
        List<clsAuthor> mAuthorList = new List<clsAuthor>();

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
        public clsAuthor ThisAuthor { get; set; }

        // Constructor for the class
        public clsAuthorCollection()
        {
            // Variable for the index
            int Index = 0;
            // Variable to store the record count
            int RecordCount = 0;
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblAuthor_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank author
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

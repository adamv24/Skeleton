using System;

namespace ClassLibrary
{
    public class clsAuthor
    {
        // Private data members to store author properties
        private int mAuthorId;
        private string mAuthorName;
        private string mAuthorBiography;
        private DateTime mDateJoined;
        private bool mIsBestSeller;
        private decimal mAverageRating;
        private int mTotalBooksSold;

        // Public property for AuthorId
        public int AuthorId
        {
            get
            {
                // Return the value of the private data member mAuthorId
                return mAuthorId;
            }
            set
            {
                // Set the value of the private data member mAuthorId
                mAuthorId = value;
            }
        }

        // Public property for AuthorName
        public string AuthorName
        {
            get
            {
                // Return the value of the private data member mAuthorName
                return mAuthorName;
            }
            set
            {
                // Set the value of the private data member mAuthorName
                mAuthorName = value;
            }
        }

        // Public property for AuthorBiography
        public string AuthorBiography
        {
            get
            {
                // Return the value of the private data member mAuthorBiography
                return mAuthorBiography;
            }
            set
            {
                // Set the value of the private data member mAuthorBiography
                mAuthorBiography = value;
            }
        }

        // Public property for DateJoined
        public DateTime DateJoined
        {
            get
            {
                // Return the value of the private data member mDateJoined
                return mDateJoined;
            }
            set
            {
                // Set the value of the private data member mDateJoined
                mDateJoined = value;
            }
        }

        // Public property for IsBestSeller
        public bool IsBestSeller
        {
            get
            {
                // Return the value of the private data member mIsBestSeller
                return mIsBestSeller;
            }
            set
            {
                // Set the value of the private data member mIsBestSeller
                mIsBestSeller = value;
            }
        }

        // Public property for AverageRating
        public decimal AverageRating
        {
            get
            {
                // Return the value of the private data member mAverageRating
                return mAverageRating;
            }
            set
            {
                // Set the value of the private data member mAverageRating
                mAverageRating = value;
            }
        }

        // Public property for TotalBooksSold
        public int TotalBooksSold
        {
            get
            {
                // Return the value of the private data member mTotalBooksSold
                return mTotalBooksSold;
            }
            set
            {
                // Set the value of the private data member mTotalBooksSold
                mTotalBooksSold = value;
            }
        }

        // Find method (placeholder)
        public bool Find(int authorId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the author id to search for
            DB.AddParameter("@AuthorId", authorId);
            // Execute the stored procedure
            DB.Execute("sproc_tblAuthor_FilterByAuthorId");
            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mAuthorId = Convert.ToInt32(DB.DataTable.Rows[0]["AuthorId"]);
                mAuthorName = Convert.ToString(DB.DataTable.Rows[0]["AuthorName"]);
                mAuthorBiography = Convert.ToString(DB.DataTable.Rows[0]["AuthorBiography"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mIsBestSeller = Convert.ToBoolean(DB.DataTable.Rows[0]["IsBestseller"]);
                mAverageRating = Convert.ToDecimal(DB.DataTable.Rows[0]["AverageRating"]);
                mTotalBooksSold = Convert.ToInt32(DB.DataTable.Rows[0]["TotalBooksSold"]);
                // Return that everything worked OK
                return true;
            }
            else
            {
                // If no record was found
                return false;
            }
        }
    }
}

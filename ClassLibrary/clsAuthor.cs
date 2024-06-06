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

        //valid method
        public string Valid(string authorName, string authorBiography, string dateJoined, string averageRating, string totalBooksSold)
        {
            // Initialize an empty error string
            string Error = "";
            DateTime DateTemp;
            decimal AvgRatingTemp;
            int TotalBooksSoldTemp;


            // Validation for AuthorName
            if (authorName.Length == 0) // Check if AuthorName is empty
            {
                Error += "The author name may not be blank : "; // Append error message
            }
            if (authorName.Length > 25) // Check if AuthorName exceeds 25 characters
            {
                Error += "The author name must be less than 26 characters : "; // Append error message
            }

            // Validation for AuthorBiography
            if (authorBiography.Length == 0) // Check if AuthorBiography is empty
            {
                Error += "The author biography may not be blank : "; // Append error message
            }
            if (authorBiography.Length > 500) // Check if AuthorBiography exceeds 500 characters
            {
                Error += "The author biography must be less than 501 characters : "; // Append error message
            }

            // Validation for DateJoined
            try
            {
                DateTemp = Convert.ToDateTime(dateJoined); // Attempt to convert DateJoined to DateTime
                if (DateTemp < DateTime.Now.Date) // Check if DateJoined is in the past
                {
                    Error += "The date cannot be in the past : "; // Append error message
                }
                if (DateTemp > DateTime.Now.Date) // Check if DateJoined is in the future
                {
                    Error += "The date cannot be in the future : "; // Append error message
                }
            }
            catch
            {
                Error += "The date was not a valid date : "; // Append error message if conversion fails
            }

            // Validation for AverageRating
            try
            {
                AvgRatingTemp = Convert.ToDecimal(averageRating); // Attempt to convert AverageRating to decimal
                if (AvgRatingTemp < 0 || AvgRatingTemp > 5) // Check if AverageRating is within valid range
                {
                    Error += "The average rating must be between 0 and 5 : "; // Append error message
                }
            }
            catch
            {
                Error += "The average rating was not a valid decimal : "; // Append error message if conversion fails
            }

            // Validation for TotalBooksSold
            try
            {
                TotalBooksSoldTemp = Convert.ToInt32(totalBooksSold); // Attempt to convert TotalBooksSold to int
                if (TotalBooksSoldTemp < 0) // Check if TotalBooksSold is non-negative
                {
                    Error += "The total books sold cannot be negative : "; // Append error message
                }
                // Check if the quantityAvailable is negative
                if (TotalBooksSoldTemp > 2147483647)
                {
                    // Record the error
                    Error = Error + "The total books sold cannot be more than 2147483647 : ";
                }
            }
            catch
            {
                Error += "The total books sold was not a valid integer : "; // Append error message if conversion fails
            }

            // Return the concatenated error string
            return Error;
        }






    }
}

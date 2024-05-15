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
            // Placeholder implementation: Assume the author with the provided ID is found
            // Replace this with the actual logic to retrieve author data from the database
            mAuthorId = authorId;
            mAuthorName = "John Doe";
            mAuthorBiography = "John Doe is a famous author...";
            mDateJoined = Convert.ToDateTime("01/01/2023");
            mIsBestSeller = true;
            mAverageRating = 4.5m;
            mTotalBooksSold = 10000;

            return true;
        }
    }
}

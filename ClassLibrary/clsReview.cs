using System;

namespace ClassLibrary
{
    public class clsReview
    {
        private Int32 mUserId;
        private Int32 mReviewId;
        private Int32 mBookId;
        private Int32 mRatingId;
        private String mText;
        private Boolean mActive;
        private DateTime mDateAdded;



        public string revText;

        public string Text
        {
            get
            {
                //this line of code sends data out of the property
                return mText;
            }
            set
            {
                //this line of code allows data into the property
                mText = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }


        public int UserId
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }
        public int BookId
        {
            get
            {
                return mBookId;
            }
            set
            {
                mBookId = value;
            }
        }
        public int ReviewId
        {
            get
            {
                return mReviewId;
            }
            set
            {
                mReviewId = value;
            }
        }
        public int RatingId
        {
            get
            {
                return mRatingId;
            }
            set
            {
                mRatingId = value;
            }
        }


        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        public bool Find(int userId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", userId);
            DB.Execute("sproc_tblReview_FilterByReviewId");
            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mReviewId = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewId"]);
                mRatingId = Convert.ToInt32(DB.DataTable.Rows[0]["Rating"]);
                mBookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["ReviewSubmited"]);
                mText = Convert.ToString(DB.DataTable.Rows[0]["ReviewText"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FindReviewId(int ReviewId)
        {
            mReviewId = 2;
            return true;
        }

        public bool FindRatingId(int RatingId)
        {
            mRatingId = 4;
            return true;
        }

        public bool FindBookId(int BookId)
        {
            mBookId = 1;
            return true;
        }

        public bool FindTextId(int Text)
        {
            mText = "I like this BOOK! It has a great storyline!";
            return true;
        }

        public bool FindActiveId(int Active)
        {
            mActive = true;
            return true;
        }
    }
}
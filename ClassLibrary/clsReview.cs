using System;
using System.Linq.Expressions;

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

        public string Valid(int bookId, int reviewId, int rating, string reviewText, string DateAdded)
        {
            String Error = "";
            DateTime DateTemp;
            if (bookId == 0 || reviewId == 0)
            {
                Error = Error + "The Book Id OR reviewId Cannot Be Blank";
            }
            else if (bookId < 1 || reviewId < 1)
            {
                Error = Error + "The Book Id OR reviewId Cannot Be less Than 1";
            }
            else if (bookId > 2147483647)
            {
                Error = Error + "The Book Id OR reviewId Cannot be Greater than 2147483647";
            }
            DateTime day = DateTime.Now;
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp > day)
                {
                    Error = Error + "The date cannot be in the future";
                }
                if (DateTemp < day)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }


            catch
            {
                Error = Error + "Date was not valid or format";
            }
            return Error;
        }
        

        public string Valid2(int bookId, int reviewId, string rating, string reviewText, string DateAdded)
        {
            String Error = "";
            if (rating.Length == 0)
            {
                Error = Error + "The rating Cannot Be Blank";
            }
            else if (rating.Length < 1)
            {
                Error = Error + "The rating Cannot Be less Than 1";
            }
            else if (rating.Length >= 6 && rating.Length < 500) 
            {
                Error = Error + "The rating Cannot be Greater than 5";
            }
            else if (rating.Length > 500)
            {
                Error = Error + "The rating Cannot be Greater than 500";
            }
            else if (reviewText.Length == 0)
            {
                Error = Error + "The review Cannot Be Blank";
            }
            else if (reviewText.Length < 1)
            {
                Error = Error + "The review Cannot Be less Than 1";
            }
            else if (reviewText.Length >= 51 && rating.Length < 500)
            {
                Error = Error + "The review Cannot be Greater than 50";
            }
            else if (reviewText.Length > 500)
            {
                Error = Error + "The review Cannot be Greater than 500";
            }
            return Error;
        }
    }
}
﻿using System;

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
        public bool Find(int UserId)
        {
            mUserId = 21;
            return true;
        }

        public bool FindReviewId(int ReviewId)
        {
            mReviewId = 31;
            return true;
        }

        public bool FindRatingId(int RatingId)
        {
            mRatingId = 21;
            return true;
        }

        public bool FindBookId(int BookId)
        {
            mBookId = 21;
            return true;
        }

        public bool FindTextId(int Text)
        {
            mText = "Good Book";
            return true;
        }

        public bool FindActiveId(int Active)
        {
            mActive = false;
            return true;
        }
    }
}
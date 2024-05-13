using System;

namespace ClassLibrary
{
    public class clsReview
    {
        private Int32 mUserId;
        public string revText;

        public bool Active { get; set; }
        public string Text { get; set; }
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
        public int BookId { get; set; }
        public int ReviewId { get; set; }
        public int RatingId { get; set; }

        public bool Find(int UserId)
        {
            mUserId = 21;
            return true;
        }
    }
}
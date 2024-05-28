using System;
using System.Collections.Generic;
using System.Data;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();

        clsReview mThisReview = new clsReview();
        public clsReviewCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblBookReviews_SelectAll");
            PopulateArray(DB);
        }

        public List<clsReview> ReviewList { get
            {
                return mReviewList;
            }
            set
            {
                mReviewList = value;
            }
        }
        public int Count 
        { get
            {
                return mReviewList.Count;
            }
            set
            {
                
            }
        }
        public clsReview ThisReview
        {
            get
            {
                return mThisReview;
            }
            set
            {
                mThisReview = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookId", mThisReview.BookId);
            DB.AddParameter("@ReviewId", mThisReview.ReviewId);
            DB.AddParameter("@DateAdded", mThisReview.DateAdded);
            DB.AddParameter("@Rating", mThisReview.RatingId);
            DB.AddParameter("@ReviewText", mThisReview.Text);
            DB.AddParameter("@ReviewSubmitted", mThisReview.Active);

            return DB.Execute("sproc_tblReviews_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", mThisReview.UserId);
            DB.AddParameter("@BookId", mThisReview.BookId);
            DB.AddParameter("@ReviewId", mThisReview.ReviewId);
            DB.AddParameter("@DateAdded", mThisReview.DateAdded);
            DB.AddParameter("@Rating", mThisReview.RatingId);
            DB.AddParameter("@ReviewText", mThisReview.Text);
            DB.AddParameter("@ReviewSubmitted", mThisReview.Active);

            DB.Execute("sproc_tblReviews_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mReviewList = new List<clsReview>();
            while (Index < RecordCount)
            {
                clsReview anReview = new clsReview();
                anReview.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["UserId"]);
                anReview.ReviewId = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewId"]);
                anReview.RatingId = Convert.ToString(DB.DataTable.Rows[Index]["Rating"]);
                anReview.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                anReview.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReviewSubmited"]);
                anReview.Text = Convert.ToString(DB.DataTable.Rows[Index]["ReviewText"]);
                anReview.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mReviewList.Add(anReview);
                Index++;
            }
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", mThisReview.UserId);
            DB.Execute("sproc_tblReview_Delete");
        }

        public void ReportByReviewText(string ReviewText)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewText", ReviewText);
            DB.Execute("sproc_tblReviews_FilterByReviewText");
            PopulateArray(DB);
        }

        public void ReportByRevText(string ReviewText)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewText", ReviewText);
            DB.Execute("sproc_tblReviews_FilterByRevText");
            PopulateArray(DB);
        }
    }
}
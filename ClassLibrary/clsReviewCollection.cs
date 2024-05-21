﻿using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();
        clsReview mThisReview = new clsReview();
        public clsReviewCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblBookReviews_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsReview anReview = new clsReview();
                anReview.UserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                anReview.ReviewId = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewId"]);
                anReview.RatingId = Convert.ToString(DB.DataTable.Rows[0]["Rating"]);
                anReview.BookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                anReview.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["ReviewSubmited"]);
                anReview.Text = Convert.ToString(DB.DataTable.Rows[0]["ReviewText"]);
                anReview.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mReviewlist.Add(anReview);
                Index++;
            }
        }

        //private data member for the list
        List<clsReview> mReviewlist = new List<clsReview>();
        public List<clsReview> ReviewList { get
            {
                return mReviewlist;
            }
            set
            {
                mReviewlist = value;
            }
        }
        public int Count { get
            {
                return mReviewlist.Count;
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
        public void AddMethodOK()
        {
            clsReviewCollection allReviews = new clsReviewCollection();
            clsReview TestItem = new clsReview();

            TestItem.Active = true;
            TestItem.UserId = 1;
            TestItem.ReviewId = 1;
            TestItem.BookId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.RatingId = "3";
            TestItem.Text = "1";
            allReviews.ThisReview = TestItem;
            PrimaryKey = allReviews.Add();
            TestItem.UserId = PrimaryKey;
            allReviews.ThisReview.Find(PrimaryKey);
            Assert.AreEqual(allReviews.ThisReview, TestItem);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookId", mThisReview.BookId);
            DB.AddParameter(@ReviewId, )
        }
    }


}
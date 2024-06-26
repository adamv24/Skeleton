﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstReviewCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReviewCollection allReview = new clsReviewCollection();
            Assert.IsNotNull(allReview);
        }

        [TestMethod]
        public void ReviewListOK()
        {
            clsReviewCollection allReview = new clsReviewCollection();
            List<clsReview> TestList = new List<clsReview>();
            clsReview TestItem = new clsReview();

            TestItem.Active = true;
            TestItem.UserId = 1;
            TestItem.ReviewId = 1;
            TestItem.BookId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.RatingId = "3";
            TestItem.Text = "1";
            TestList.Add(TestItem);
            allReview.ReviewList = TestList;
            Assert.AreEqual(allReview.ReviewList, TestList);
        }

        [TestMethod]
        public void ThisReviewPropertyOK()
        {
            clsReviewCollection allReview = new clsReviewCollection();
            clsReview TestReview = new clsReview();
            TestReview.Active = true;
            TestReview.UserId = 1;
            TestReview.ReviewId = 1;
            TestReview.BookId = 1;
            TestReview.DateAdded = DateTime.Now;
            TestReview.RatingId = "3";
            TestReview.Text = "1";

            allReview.ThisReview = TestReview;
            Assert.AreEqual(allReview.ThisReview, TestReview);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsReviewCollection allReview = new clsReviewCollection();
            List<clsReview> TestList = new List<clsReview>();
            clsReview TestItem = new clsReview();

            TestItem.Active = true;
            TestItem.UserId = 1;
            TestItem.ReviewId = 1;
            TestItem.BookId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.RatingId = "3";
            TestItem.Text = "1";
            TestList.Add(TestItem);
            allReview.ReviewList = TestList;
            Assert.AreEqual(allReview.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsReviewCollection allReviews = new clsReviewCollection();
            clsReview TestItem = new clsReview();
            Int32 PrimaryKey = 0;
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

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsReviewCollection allReviews = new clsReviewCollection();
            clsReview TestItem = new clsReview();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.UserId = 2;
            TestItem.ReviewId = 3;
            TestItem.BookId = 4;
            TestItem.DateAdded = DateTime.Now;
            TestItem.RatingId = "3";
            TestItem.Text = "Good Book";
            allReviews.ThisReview = TestItem;
            PrimaryKey = allReviews.Add();
            TestItem.UserId = PrimaryKey;
            allReviews.ThisReview.Find(PrimaryKey);
            allReviews.Delete();
            Boolean Found = allReviews.ThisReview.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByTextMethodOK()
        {
            clsReviewCollection allReviews = new clsReviewCollection();
            clsReviewCollection filteredReview = new clsReviewCollection();
            filteredReview.ReportByRevText("");
            Assert.AreEqual(allReviews.Count, filteredReview.Count);
        }

        [TestMethod]
        public void ReportByRevTextNoneFoundOK() {
            clsReviewCollection filteredReviews = new clsReviewCollection();
            filteredReviews.ReportByRevText("xxx xxx");
            Assert.AreEqual(0, filteredReviews.Count);
        }

        [TestMethod]
        public void ReportByReviewTextTestDataFound()
        {
            clsReviewCollection filteredReviews = new clsReviewCollection();
            Boolean OK = true;
            filteredReviews.ReportByRevText("Nice");
            if(filteredReviews.Count == 2)
            {
                if (filteredReviews.ReviewList[0].UserId != 17)
                {
                    OK = false;
                }
                if (filteredReviews.ReviewList[1].UserId != 19)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        

        [TestMethod]
        public void UpdateMethodOK()
        {
            Int32 PrimaryKey = 0;
            clsReviewCollection allReview = new clsReviewCollection();
            clsReview TestItem = new clsReview();
            TestItem.Active = true;
            TestItem.UserId = 1;
            TestItem.ReviewId = 1;
            TestItem.BookId = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.RatingId = "3";
            TestItem.Text = "1";
            allReview.ThisReview = TestItem;
            PrimaryKey = allReview.Add();
            TestItem.UserId = PrimaryKey;

            TestItem.Active = false;
            TestItem.UserId = 13;
            TestItem.ReviewId = 12;
            TestItem.BookId = 12;
            TestItem.DateAdded = DateTime.Now;
            TestItem.RatingId = "23";
            TestItem.Text = "5";
            allReview.ThisReview = TestItem;
            allReview.Update();
            allReview.ThisReview.Find(PrimaryKey);
            Assert.AreEqual(allReview.ThisReview, TestItem);

        }


        
    }
}

﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsReview anReview = new clsReview();

            Boolean TestData = true;

            anReview.Active = TestData;

            Assert.AreEqual(anReview.Active, TestData);
        }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //test to see that it exists
            Assert.IsNotNull(AnReview);
        }

        [TestMethod]
        public void ReviewTextOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            string TestData = "Review Text";
            //assign the data to the property
            AnReview.Text = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.Text, TestData);
        }
        public void ReviewText1OK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            string TestData = "Review Text";
            //assign the data to the property
            AnReview.revText = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.revText, TestData);
        }

        [TestMethod]
        public void UserIdOK()
        {
            //create an instance of the class we want to create
            clsReview AnReviewId = new clsReview();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReviewId.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReviewId.UserId, TestData);
        }

        [TestMethod]
        public void UserBookIdOK()
        {
            //create an instance of the class we want to create
            clsReview AnBookId = new clsReview();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnBookId.BookId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnBookId.BookId, TestData);
        }

        [TestMethod]
        public void ReviewIdOK()
        {
            //create an instance of the class we want to create
            clsReview AnReviewId = new clsReview();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnReviewId.ReviewId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReviewId.ReviewId, TestData);
        }

        [TestMethod]
        public void RatingIdOK()
        {
            clsReview AnRatingId = new clsReview();
            Int32 TestData = 1;
            AnRatingId.RatingId = TestData;
            Assert.AreEqual(AnRatingId.RatingId, TestData);
        }

        [TestMethod]
        public void ReviewSubmittedOK()
        {
            clsReview AnSubmittedReview = new clsReview();
            Boolean TestData = true;
            AnSubmittedReview.Active = TestData;
            Assert.AreEqual(AnSubmittedReview.Active, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Int32 UserId = 21;
            Found = AnReview.Find(UserId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 21;
            Found = AnReview.Find(UserId);

            if (AnReview.UserId != 21)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReviewIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ReviewId = 31;
            Found = AnReview.Find(ReviewId);

            if (AnReview.ReviewId != 21)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = AnReview.Find(BookId);

            if (AnReview.BookId != 21)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRatingIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RatingId = 21;
            Found = AnReview.Find(RatingId);

            if (AnReview.RatingId != 21)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTextOK()
        {
            clsReview AnReview = new clsReview();
            string TestData = "Good Book";
            AnReview.Text = TestData;
            Assert.AreEqual(AnReview.Text, TestData);

        }

        [TestMethod]
        public void TestTextFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int Text = 21;
            //invoke the method
            Found = AnReview.FindTextId(Text);
            //check the post code property
            if (AnReview.Text != "Good Book")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
                }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Active = 21;
            //invoke the method
            Found = AnReview.FindActiveId(Active);
            //check the active property
            if (AnReview.Active != true)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
                
    }
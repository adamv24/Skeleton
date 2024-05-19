using ClassLibrary;
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
        int BookId = 1;
        int ReviewId = 2;
        int Rating = 4;
        String ReviewText = "A Good Book";
        String DateAdded = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsReview AnReview = new clsReview();

            Boolean TestData = true;

            AnReview.Active = TestData;

            Assert.AreEqual(AnReview.Active, TestData);
        }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsReview AnReviews = new clsReview();
            //test to see that it exists
            Assert.IsNotNull(AnReviews);
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

        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnReview.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.DateAdded, TestData);
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
            Int32 TestData = 5;
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
            Int32 TestData = 5;
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
            Int32 UserId = 6;
            Found = AnReview.Find(UserId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 6;
            //invoke the method
            Found = AnReview.Find(UserId);

            if (AnReview.UserId != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReviewIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 6;
            //invoke the method
            Found = AnReview.Find(UserId);

            if (AnReview.ReviewId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 6;
            //invoke the method
            Found = AnReview.Find(UserId);

            if (AnReview.BookId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 6;
            //invoke the method
            Found = AnReview.Find(UserId);

            if (AnReview.DateAdded != Convert.ToDateTime("05/01/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRatingIdFound()
        {
            clsReview AnReview = new clsReview();
            Boolean Found = false;
            Boolean OK = true;
            Int32 UserId = 6;
            //invoke the method
            Found = AnReview.Find(UserId);

            if (AnReview.RatingId != 4)
            {
                OK = false;
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
            Int32 UserId = 6;
            //invoke the method
            Found = AnReview.Find(UserId);
            //check the post code property
            if (AnReview.Text != "I like this BOOK! It has a great storyline!")
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
            Int32 UserId = 6;
            //invoke the method
            Found = AnReview.Find(UserId);
            //check the active property
            if (AnReview.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
        }

        [TestMethod]
        public void BookIdMinLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int BookId = 0;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int BookId = 1;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int BookId = 2;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void BookIdMaxLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int BookId = 2147483646;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int BookId = 2147483647;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMid()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int BookId = 1147483647;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookIdMaxPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int BookId = 214748364;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewIdMinLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int ReviewId = 0;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReviewIdMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int ReviewId = 1;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewIdMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int ReviewId = 2;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ReviewIdMaxLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int ReviewId = 2147483646;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewIdMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int ReviewId = 2147483647;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewIdMid()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int ReviewId = 1147483647;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewIdMaxPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            int ReviewId = 214748364;
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "a";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "a";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "aa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMaxLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "aaaaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "aaaaaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RatingMid()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "aaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RatingMaxPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "aaaaaaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RatingExtremeMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "";
            Rating = Rating.PadRight(400, 'a');
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        /// <summary>
        /// //
        /// </summary>

        

        [TestMethod]
        public void ReviewTextLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string Rating = "a";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewTextMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewText = "a";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewText = "aa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewMaxLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewText = "aaaaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewText = "aaaaaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReviewMid()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewText = "aaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReviewMaxPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewText = "aaaaaaa";
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ReviewExtremeMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewText = "";
            Rating = ReviewText.PadRight(400, 'a');
            Error = AnReview.Valid2(BookId, ReviewId, Rating, ReviewText, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsReview anReview = new clsReview();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsReview anReview = new clsReview();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
 public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsReview anReview = new clsReview();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsReview anReview = new clsReview();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsReview anReview = new clsReview();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnReview.Valid(BookId, ReviewId, Rating, ReviewText, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
                
    }

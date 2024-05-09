using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a instance of the class we want ot create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void IsbnIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.IsbnID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.IsbnID, TestData);
        }

        [TestMethod]
        public void BookNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Some book";
            //assign the data to the property
            AStock.BookName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.BookName, TestData);
        }

        [TestMethod]
        public void BookAuthorPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "An author";
            //assign the data to the property
            AStock.BookAuthor = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.BookAuthor, TestData);
        }

        [TestMethod]
        public void QuantityAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            AStock.QuantityAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.QuantityAvailable, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Decimal TestData = 9.50m;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 IsbnID = 5;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestIsbnIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IsbnID = 5;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the address id property
            if (AStock.IsbnID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IsbnID = 5;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the date added property
            if (AStock.DateAdded != Convert.ToDateTime("09/05/2024"))
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
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IsbnID = 5;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the active property
            if (AStock.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IsbnID = 5;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the town property
            if (AStock.BookName != "book name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestBookAuthorFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IsbnID = 5;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the town property
            if (AStock.BookAuthor != "author")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 IsbnID = 5;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the address id property
            if (AStock.QuantityAvailable != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int IsbnId = 5;
            //invoke the method
            Found = AStock.Find(IsbnId);
            //check the price property
            if (AStock.Price != 4.99m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        /*****************VALID METHOD TEST******************/
        //good test data
        //create some test data to pass the method
        string BookName = "book name";
        string BookAuthor = "author";
        string Price = "1.99";
        string DateAdded = DateTime.Now.ToShortDateString();
        string QuantityAvailable = "5";

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store  any error message
            String Error = "";
            //invoke the methods
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        /****************BOUNDARY TESTS*****************/
        //DATEADDED BOUNDARY TESTS
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
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
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidDate()
        {
            //create a new instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //BOOK NAME BOUNDARY TESTS
        [TestMethod]
        public void BookNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BookName = "";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookName = "a";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookName = "aa";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookName = "";
            BookName = BookName.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookName = "";
            BookName = BookName.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BookName = "";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookName = "";
            BookName = BookName.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //BOOK AUTHOR BOUNDARY TESTS
        [TestMethod]
        public void BookAuthorMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BookAuthor = "";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookAuthorMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookAuthor = "a";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookAuthorPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookAuthor = "aa";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookAuthorMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookAuthor = "";
            BookAuthor = BookAuthor.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookAuthorMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookAuthor = "";
            BookAuthor = BookAuthor.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookAuthorMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string BookAuthor = "";
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookAuthorMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string BookAuthor = "";
            BookAuthor = BookAuthor.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, BookAuthor, Price, DateAdded, QuantityAvailable);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }

}

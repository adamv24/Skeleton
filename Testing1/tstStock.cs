using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Int32 IsbnID = 21;
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
            Int32 IsbnID = 21;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the address id property
            if (AStock.IsbnID != 21)
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
            Int32 IsbnID = 21;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the date added property
            if (AStock.DateAdded != Convert.ToDateTime("23/12/2022"))
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
            Int32 IsbnID = 21;
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
            Int32 IsbnID = 21;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the town property
            if (AStock.BookName != "Book Name")
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
            Int32 IsbnID = 21;
            //invoke the method
            Found = AStock.Find(IsbnID);
            //check the town property
            if (AStock.BookAuthor != "Book Author")
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
            Int32 IsbnID = 21;
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
            int IsbnId = 21;
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



    }
}

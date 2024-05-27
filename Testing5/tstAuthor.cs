using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstAuthor
    {
        // Good test data
        private string AuthorId = "123";
        private string AuthorName = "Test Author";
        private string AuthorBiography = "Test Biography";
        private string DateJoined = DateTime.Now.Date.ToString();
        private string AverageRating = "4.5";
        private string TotalBooksSold = "10000";

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            String Error = "";
            // Invoke the method
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //test to see that it exists
            Assert.IsNotNull(AnAuthor);
        }

        [TestMethod]
        public void IsBestSellerPropertyOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAuthor.IsBestSeller = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAuthor.IsBestSeller, TestData);
        }
        [TestMethod]
        public void AuthorIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAuthor.AuthorId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAuthor.AuthorId, TestData);
        }

        [TestMethod]
        public void AuthorNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create some test data to assign to the property
            string TestData = "John Doe";
            //assign the data to the property
            AnAuthor.AuthorName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAuthor.AuthorName, TestData);
        }

        [TestMethod]
        public void AuthorBiographyPropertyOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create some test data to assign to the property
            string TestData = "John Doe is a famous author...";
            //assign the data to the property
            AnAuthor.AuthorBiography = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAuthor.AuthorBiography, TestData);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAuthor.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAuthor.DateJoined, TestData);
        }

        [TestMethod]
        public void AverageRatingPropertyOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create some test data to assign to the property
            decimal TestData = 4.5m;
            //assign the data to the property
            AnAuthor.AverageRating = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAuthor.AverageRating, TestData);
        }

        [TestMethod]
        public void TotalBooksSoldPropertyOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create some test data to assign to the property
            Int32 TestData = 10000;
            //assign the data to the property
            AnAuthor.TotalBooksSold = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAuthor.TotalBooksSold, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAuthorIdFound()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //check the author id
            if (AnAuthor.AuthorId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAuthorNameFound()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //check the author name property
            if (AnAuthor.AuthorName == "John Doe")
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAuthorBiographyFound()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //check the author biography property
            if (AnAuthor.AuthorBiography != "John Doe is a famous author...")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //check the date joined property
            if (AnAuthor.DateJoined != Convert.ToDateTime("01/01/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsBestSellerFound()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //check the is best seller property
            if (AnAuthor.IsBestSeller != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAverageRatingFound()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //check the average rating property
            if (AnAuthor.AverageRating != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalBooksSoldFound()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AuthorId = 21;
            //invoke the method
            Found = AnAuthor.Find(AuthorId);
            //check the total books sold property
            if (AnAuthor.TotalBooksSold != 10000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //DATEJOINED TESTS

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create a DateTime variable and set it to today's date
            DateTime TestDate = DateTime.Now.Date;
            // Change the date to 100 years ago
            TestDate = TestDate.AddYears(-100);
            // Convert the date to a string
            string DateJoined = TestDate.ToString();
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create a DateTime variable and set it to today's date
            DateTime TestDate = DateTime.Now.Date;
            // Change the date to one day before today
            TestDate = TestDate.AddDays(-1);
            // Convert the date to a string
            string DateJoined = TestDate.ToString();
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMin()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create a DateTime variable and set it to today's date
            DateTime TestDate = DateTime.Now.Date;
            // Convert the date to a string
            string DateJoined = TestDate.ToString();
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create a DateTime variable and set it to today's date
            DateTime TestDate = DateTime.Now.Date;
            // Change the date to one day after today
            TestDate = TestDate.AddDays(1);
            // Convert the date to a string
            string DateJoined = TestDate.ToString();
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create a DateTime variable and set it to today's date
            DateTime TestDate = DateTime.Now.Date;
            // Change the date to 100 years in the future
            TestDate = TestDate.AddYears(100);
            // Convert the date to a string
            string DateJoined = TestDate.ToString();
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedInvalidData()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Use an invalid date string
            string DateJoined = "this is not a date";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        //AUTHORNAME TESTS

        [TestMethod]
        public void AuthorNameMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author name being less than the minimum allowed length
            string AuthorName = "";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorNameMin()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author name being the minimum allowed length
            string AuthorName = "a";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorNameMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author name being one character more than the minimum allowed length
            string AuthorName = "aa";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorNameMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author name being one character less than the maximum allowed length
            string AuthorName = new string('a', 24);
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorNameMax()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author name being the maximum allowed length
            string AuthorName = new string('a', 25);
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorNameMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author name being one character more than the maximum allowed length
            string AuthorName = new string('a', 26);
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorNameMid()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author name being a mid-range length
            string AuthorName = new string('a', 12);
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        //AUTHORBIOGRAPHY TESTS

        [TestMethod]
        public void AuthorBiographyMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author biography being less than the minimum allowed length
            string AuthorBiography = "";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorBiographyMin()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author biography being the minimum allowed length
            string AuthorBiography = "a";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorBiographyMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author biography being one character more than the minimum allowed length
            string AuthorBiography = "aa";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorBiographyMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author biography being one character less than the maximum allowed length
            string AuthorBiography = new string('a', 499); // Assuming a max length of 500 for the example
                                                           // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorBiographyMax()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author biography being the maximum allowed length
            string AuthorBiography = new string('a', 500); // Assuming a max length of 500 for the example
                                                           // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorBiographyMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author biography being one character more than the maximum allowed length
            string AuthorBiography = new string('a', 501); // Assuming a max length of 500 for the example
                                                           // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorBiographyMid()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the author biography being a mid-range length
            string AuthorBiography = new string('a', 250); // Assuming a max length of 500 for the example
                                                           // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        //AVERAGERATING TESTS

        [TestMethod]
        public void AverageRatingMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the average rating being less than the minimum allowed value
            string AverageRating = "-0.1";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AverageRatingMin()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the average rating being the minimum allowed value
            string AverageRating = "0";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AverageRatingMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the average rating being one unit more than the minimum allowed value
            string AverageRating = "0.1";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AverageRatingMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the average rating being one unit less than the maximum allowed value
            string AverageRating = "4.9";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AverageRatingMax()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the average rating being the maximum allowed value
            string AverageRating = "5";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AverageRatingMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the average rating being one unit more than the maximum allowed value
            string AverageRating = "5.1";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AverageRatingMid()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the average rating being a mid-range value
            string AverageRating = "2.5";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        //TOTALBOOKSSOLD TESTS

        [TestMethod]
        public void TotalBooksSoldMinLessOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the total books sold being less than the minimum allowed value (negative number)
            string TotalBooksSold = "-1";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalBooksSoldMin()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the total books sold being the minimum allowed value (zero)
            string TotalBooksSold = "0";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalBooksSoldMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the total books sold being one unit more than the minimum allowed value
            string TotalBooksSold = "1";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalBooksSoldValidNumber()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with a valid total books sold value
            string TotalBooksSold = "999999";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalBooksSoldMid()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Create test data with the total books sold being a mid-range value
            string TotalBooksSold = "500000";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is blank (indicating no error was found)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalBooksSoldInvalidData()
        {
            // Create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            // String variable to store any error message
            string Error = "";
            // Use an invalid total books sold value (non-integer)
            string TotalBooksSold = "one hundred";
            // Invoke the Valid method with the test data
            Error = AnAuthor.Valid(AuthorId, AuthorName, AuthorBiography, DateJoined, AverageRating, TotalBooksSold);
            // Assert that the error message is not blank (indicating an error was found)
            Assert.AreNotEqual(Error, "");
        }


    }

}

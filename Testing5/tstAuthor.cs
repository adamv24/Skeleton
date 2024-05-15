using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstAuthor
    {
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

    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstAuthorGenre
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
    }

       
    }


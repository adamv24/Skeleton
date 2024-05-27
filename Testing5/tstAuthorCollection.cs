using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstAuthorCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            // Create an instance of the class we want to create
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            // Test to see that it exists
            Assert.IsNotNull(AllAuthors);
        }

        [TestMethod]
        public void AuthorListOk()
        {
            // Create an instance of the class we want to create
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            // Create some test data to assign to the property
            // In this case, the data needs to be a list of objects
            List<clsAuthor> TestList = new List<clsAuthor>();
            // Add an item to the list
            // Create the item of test data
            clsAuthor TestItem = new clsAuthor();
            // Set its properties
            TestItem.AuthorId = 1;
            TestItem.AuthorName = "Test Author";
            TestItem.AuthorBiography = "Test Biography";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.IsBestSeller = true;
            TestItem.AverageRating = 4.5m;
            TestItem.TotalBooksSold = 10000;
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllAuthors.AuthorList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllAuthors.AuthorList, TestList);
        }


        [TestMethod]
        public void ThisAuthorPropertyOK()
        {
            // Create an instance of the class we want to create
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            // Create some test data to assign to the property
            clsAuthor TestAuthor = new clsAuthor();
            // Set the properties of the test object
            TestAuthor.AuthorId = 1;
            TestAuthor.AuthorName = "Test Author";
            TestAuthor.AuthorBiography = "Test Biography";
            TestAuthor.DateJoined = DateTime.Now.Date;
            TestAuthor.IsBestSeller = true;
            TestAuthor.AverageRating = 4.5m;
            TestAuthor.TotalBooksSold = 10000;
            // Assign the data to the property
            AllAuthors.ThisAuthor = TestAuthor;
            // Test to see that the two values are the same
            Assert.AreEqual(AllAuthors.ThisAuthor, TestAuthor);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            //create some test data to assign to the property
            List<clsAuthor> TestList = new List<clsAuthor>();
            //add an item to the list
            clsAuthor TestItem = new clsAuthor();
            //set its properties
            TestItem.AuthorId = 1;
            TestItem.AuthorName = "Test Author";
            TestItem.AuthorBiography = "Test Biography";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.IsBestSeller = true;
            TestItem.AverageRating = 4.5m;
            TestItem.TotalBooksSold = 10000;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAuthors.AuthorList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAuthors.Count, TestList.Count);
        }
    }
}

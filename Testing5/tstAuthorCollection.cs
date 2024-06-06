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

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the class we want to create
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            // Create the item of test data
            clsAuthor TestItem = new clsAuthor();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.AuthorName = "Test Author";
            TestItem.AuthorBiography = "Test Biography";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.IsBestSeller = true;
            TestItem.AverageRating = 4.5m;
            TestItem.TotalBooksSold = 10000;
            // Set ThisAuthor to the test data
            AllAuthors.ThisAuthor = TestItem;
            // Add the record
            PrimaryKey = AllAuthors.Add();
            // Set the primary key of the test data
            TestItem.AuthorId = PrimaryKey;
            // Find the record
            Boolean Found = AllAuthors.ThisAuthor.Find(PrimaryKey);
            // Test to see that the two values are the same
            Assert.AreEqual(AllAuthors.ThisAuthor, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to create
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            // Create the item of test data
            clsAuthor TestItem = new clsAuthor();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.AuthorName = "Initial Author";
            TestItem.AuthorBiography = "Initial Biography";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.IsBestSeller = true;
            TestItem.AverageRating = 4.5m;
            TestItem.TotalBooksSold = 5000;
            // Set ThisAuthor to the test data
            AllAuthors.ThisAuthor = TestItem;
            // Add the record
            PrimaryKey = AllAuthors.Add();
            // Set the primary key of the test data
            TestItem.AuthorId = PrimaryKey;
            // Modify the test data
            TestItem.AuthorName = "Updated Author";
            TestItem.AuthorBiography = "Updated Biography";
            TestItem.DateJoined = DateTime.Now.Date.AddYears(-1);
            TestItem.IsBestSeller = false;
            TestItem.AverageRating = 3.5m;
            TestItem.TotalBooksSold = 1000;
            // Set the record based on the new test data
            AllAuthors.ThisAuthor = TestItem;
            // Update the record
            AllAuthors.Update();
            // Find the record
            Boolean Found = AllAuthors.ThisAuthor.Find(PrimaryKey);
            // Test to see that the two values are the same
            Assert.AreEqual(AllAuthors.ThisAuthor, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            // Create the item of test data
            clsAuthor TestItem = new clsAuthor();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.AuthorName = "Test Author";
            TestItem.AuthorBiography = "Test Biography";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.IsBestSeller = true;
            TestItem.AverageRating = 4.5m;
            TestItem.TotalBooksSold = 5000;
            // Set ThisAuthor to the test data
            AllAuthors.ThisAuthor = TestItem;
            // Add the record
            PrimaryKey = AllAuthors.Add();
            // Set the primary key of the test data
            TestItem.AuthorId = PrimaryKey;
            // Find the record
            Boolean Found = AllAuthors.ThisAuthor.Find(PrimaryKey);
            Assert.IsTrue(Found);
            // Delete the record
            AllAuthors.Delete();
            // Now find the record
            Found = AllAuthors.ThisAuthor.Find(PrimaryKey);
            // Test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByAuthorNameMethodOK()
        {
            // Create an instance of the class containing unfiltered results
            clsAuthorCollection AllAuthors = new clsAuthorCollection();
            // Create an instance of the filtered data
            clsAuthorCollection FilteredAuthors = new clsAuthorCollection();
            // Apply a blank string (should return all records)
            FilteredAuthors.ReportByAuthorName("");
            // Test to see that the two values are the same
            Assert.AreEqual(AllAuthors.Count, FilteredAuthors.Count);
        }

        [TestMethod]
        public void ReportByAuthorNameNoneFound()
        {
            // Create an instance of the class we want to create
            clsAuthorCollection FilteredAuthors = new clsAuthorCollection();
            // Apply an author name that doesn't exist
            FilteredAuthors.ReportByAuthorName("xxx xxx");
            // Test to see that there are no records
            Assert.AreEqual(0, FilteredAuthors.Count);
        }

        [TestMethod]
        public void ReportByAuthorNameTestDataFound()
        {
            // Create an instance of the filtered data
            clsAuthorCollection FilteredAuthors = new clsAuthorCollection();
            // Variable to store the outcome
            Boolean OK = true;
            // Apply an author name that should return specific records
            FilteredAuthors.ReportByAuthorName("yyy yyy");
            // Check that the correct number of records are found
            if (FilteredAuthors.Count == 2)
            {
                // Check to see that the first record is 1
                if (FilteredAuthors.AuthorList[0].AuthorId != 34)
                {
                    OK = false;
                }
                // Check to see that the second record is 2
                if (FilteredAuthors.AuthorList[1].AuthorId != 35)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            // Test to see that there are the expected records
            Assert.IsTrue(OK);
        }

    }
}

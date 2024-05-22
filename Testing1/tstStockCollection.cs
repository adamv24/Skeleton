using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Policy;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]

        public void StockListOK()
        {
            //creat anninstance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an Item to the List
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.IsbnID = 1;
            TestItem.BookName = "a book name";
            TestItem.BookAuthor = "the books author";
            TestItem.Price = 2.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 5;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }


        [TestMethod]
        public void ThisStockPropertyOK() {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.IsbnID = 1;
            TestStock.BookName = "a book name";
            TestStock.BookAuthor = "the books author";
            TestStock.Price = 2.99m;
            TestStock.DateAdded = DateTime.Now;
            TestStock.QuantityAvailable = 5;
            TestStock.Active = true;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.IsbnID = 1;
            TestItem.BookName = "a book name";
            TestItem.BookAuthor = "the books author";
            TestItem.Price = 2.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 5;
            TestItem.Active = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsbnID = 1;
            TestItem.BookName = "a book name";
            TestItem.BookAuthor = "the books author";
            TestItem.Price = 2.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 5;
            TestItem.Active = true;
            //set ThisStock to the est data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key to the test data
            TestItem.IsbnID = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookName = "a book name";
            TestItem.BookAuthor = "the books author";
            TestItem.Price = 2.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 5;
            TestItem.Active = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.IsbnID = PrimaryKey;
            //modify the test record
            TestItem.BookName = "another book name";
            TestItem.BookAuthor = "another books author";
            TestItem.Price = 4.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 3;
            TestItem.Active = false;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookName = "another book name";
            TestItem.BookAuthor = "some books author";
            TestItem.Price = 4.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 3;
            TestItem.Active = false;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record 
            PrimaryKey = AllStocks.Add();
            //set the primary ket of the test data
            TestItem.IsbnID = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now fing the record 
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }


    }
}

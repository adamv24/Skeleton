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
        public void CountPropertyOK()
        {
            //creat an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStock.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
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
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, 2);
        }



    }
}

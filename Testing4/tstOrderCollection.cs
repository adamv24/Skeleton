using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection allOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(allOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //creat anninstance of the class we want to create
            clsOrderCollection allOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an Item to the List
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.ISBN = 1;
            TestItem.OrderId = 1;
            TestItem.Status = "active";
            TestItem.UserId = 1;
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsValid = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allOrders.OrderList, TestList);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection allOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestItem = new clsOrder();
            //set the properties of the test object
            TestItem.ISBN = 1;
            TestItem.OrderId = 1;
            TestItem.Status = "active";
            TestItem.UserId = 1;
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsValid = true;
            //assign the data to the property
            allOrder.ThisOrder = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(allOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.ISBN = 435345345;
            TestItem.OrderId = 1;
            TestItem.Status = "valid";
            TestItem.UserId = 2;
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsValid = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            Int32 PrimaryKey = 0;
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.ISBN = 435345345;
            TestItem.OrderId = 1;
            TestItem.Status = "valid";
            TestItem.UserId = 2;
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsValid = true;
            //set ThisStock to the est data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key to the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            Int32 PrimaryKey = 0;
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.ISBN = 435345345;
            TestItem.OrderId = 1;
            TestItem.Status = "valid";
            TestItem.UserId = 2;
            TestItem.CreatedAt = DateTime.Now;
            TestItem.IsValid = true;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //update the record
            PrimaryKey = AllOrder.Add();
            //set the primary key to the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
    }
}

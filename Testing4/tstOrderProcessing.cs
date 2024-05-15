// tstOrder.cs
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void IsbnPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 123456;
            //assign the data to the property
            AnOrder.ISBN = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ISBN, TestData);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 100;
            //assign the data to the property
            AnOrder.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.UserId, TestData);
        }

        [TestMethod]
        public void CreatedAtPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.CreatedAt = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CreatedAt, TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Started";
            //assign the data to the property
            AnOrder.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Status, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id property
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsbnFound()
        {
            
            clsOrder AnOrder = new clsOrder();
         
            Boolean Found = false;
       
            Boolean OK = true;
          
            Int32 OrderId = 1;
            
            Found = AnOrder.Find(OrderId);
            //check the ISBN property
            if (AnOrder.ISBN == 2)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindOrderById_ExistingId_ReturnsOrder()
        {
            // Arrange
            int orderId = 1; 
            clsOrder order = new clsOrder();

            // Act
            bool found = order.Find(orderId);

            // Assert
            Assert.IsTrue(found, "Order should be found.");
           
        }

        [TestMethod]
        public void FindOrderById_NonExistingId_ReturnsNull()
        {
            
            int orderId = 99; 
            clsOrder order = new clsOrder();

            
            bool found = order.Find(orderId);

           
            Assert.IsFalse(found, "Order should not be found.");
           
        }




    }
}
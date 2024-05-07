using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder // Changed class name to tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder(); // Changed class instantiation to clsOrder
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder(); // Changed class instantiation to clsOrder
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder = TestData; // Changed property assignment to AnOrder.Active
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData); // Changed property comparison to AnOrder.Active
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder(); // Changed class instantiation to clsOrder
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData; // Changed property assignment to AnOrder.DateAdded
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData); // Changed property comparison to AnOrder.DateAdded
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder(); // Changed class instantiation to clsOrder
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData; // Changed property assignment to AnOrder.OrderId
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData); // Changed property comparison to AnOrder.OrderId
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder(); // Changed class instantiation to clsOrder
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.ProductId = TestData; // Changed property assignment to AnOrder.ProductId
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductId, TestData); // Changed property comparison to AnOrder.ProductId
        }

        
    }
}

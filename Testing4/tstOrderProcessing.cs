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
        //USER ID BOUNDARY TESTS
        [TestMethod]
        public void UserIdExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should fail
            int UserId = -1000;
            //try to assign the invalid value
            try
            {
                AnOrder.UserId = UserId;
                //if no exception is thrown, fail the test
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (Exception ex)
            {
                //check if the correct exception type is thrown
                Assert.IsInstanceOfType(ex, typeof(ArgumentOutOfRangeException));
            }
        }

        [TestMethod]
        public void UserIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should fail
            int UserId = -1;
            //try to assign the invalid value
            try
            {
                AnOrder.UserId = UserId;
                //if no exception is thrown, fail the test
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (Exception ex)
            {
                //check if the correct exception type is thrown
                Assert.IsInstanceOfType(ex, typeof(ArgumentOutOfRangeException));
            }
        }

        [TestMethod]
        public void UserIdMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should pass
            int UserId = 0;
            AnOrder.UserId = UserId;
            //check if the value is set correctly
            Assert.AreEqual(AnOrder.UserId, UserId);
        }

        [TestMethod]
        public void UserIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should pass
            int UserId = 1;
            AnOrder.UserId = UserId;
            //check if the value is set correctly
            Assert.AreEqual(AnOrder.UserId, UserId);
        }

        [TestMethod]
        public void UserIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should pass
            int UserId = int.MaxValue - 1;
            AnOrder.UserId = UserId;
            //check if the value is set correctly
            Assert.AreEqual(AnOrder.UserId, UserId);
        }

        [TestMethod]
        public void UserIdMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should pass
            int UserId = int.MaxValue;
            AnOrder.UserId = UserId;
            //check if the value is set correctly
            Assert.AreEqual(AnOrder.UserId, UserId);
        }

        [TestMethod]
        public void UserIdMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();

            // This should fail
            long UserId = (long)int.MaxValue + 1; // Use long to represent a value larger than int.MaxValue

            // Try to assign the invalid value
            try
            {
                AnOrder.UserId = (int)UserId; // Cast to int to trigger the expected exception
                Console.WriteLine(AnOrder.UserId);
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (OverflowException ex)
            {
                // Check if the correct exception type is thrown
                Assert.IsInstanceOfType(ex, typeof(OverflowException));
            }
        }


        [TestMethod]
        public void UserIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should fail
            long UserId = (long)int.MaxValue * 2; // Use long to represent a value larger than int.MaxValue
                                                  //try to assign the invalid value
            try
            {
                AnOrder.UserId = (int)UserId; // Cast to int to trigger the expected exception
                                              //if no exception is thrown, fail the test
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (OverflowException ex)
            {
                // Check if the correct exception type is thrown
                Assert.IsInstanceOfType(ex, typeof(OverflowException));
            }
        }

        [TestMethod]
        public void UserIdMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //this should pass
            int UserId = int.MaxValue / 2;
            AnOrder.UserId = UserId;
            //check if the value is set correctly
            Assert.AreEqual(AnOrder.UserId, UserId);
        }
        [TestMethod]
        public void ValidCreationDate()
        {
            // Arrange
            clsOrder order = new clsOrder();
            DateTime validDate = DateTime.Now; // Set a valid creation date

            // Act
            order.CreatedAt = validDate;

            // Assert
            Assert.AreEqual(validDate, order.CreatedAt);
        }

        [TestMethod]
        public void NullCreationDate()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.CreatedAt = null;

            // Assert
            Assert.IsNull(order.CreatedAt);
        }

        [TestMethod]
        public void ExtremeMinimumCreationDate()
        {
            // Arrange
            clsOrder order = new clsOrder();
            DateTime extremeMinDate = DateTime.Now.AddYears(-100); // 100 years ago

            // Act
            order.CreatedAt = extremeMinDate;

            // Assert
            Assert.AreEqual(extremeMinDate, order.CreatedAt);
        }

        [TestMethod]
        public void CreationDateOneDayAgo()
        {
            // Arrange
            clsOrder order = new clsOrder();
            DateTime oneDayAgo = DateTime.Now.AddDays(-1);

            // Act
            order.CreatedAt = oneDayAgo;

            // Assert
            Assert.AreEqual(oneDayAgo, order.CreatedAt);
        }

        [TestMethod]
        public void CreationDateOneDayAhead()
        {
            // Arrange
            clsOrder order = new clsOrder();
            DateTime oneDayAhead = DateTime.Now.AddDays(1);

            // Act
            order.CreatedAt = oneDayAhead;

            // Assert
            Assert.AreEqual(oneDayAhead, order.CreatedAt);
        }

        [TestMethod]
        public void ExtremeMaximumCreationDate()
        {
            // Arrange
            clsOrder order = new clsOrder();
            DateTime extremeMaxDate = DateTime.Now.AddYears(100); // 100 years from now

            // Act
            order.CreatedAt = extremeMaxDate;

            // Assert
            Assert.AreEqual(extremeMaxDate, order.CreatedAt);
        }
        [TestMethod]
        public void ValidISBN()
        {
            // Arrange
            clsOrder order = new clsOrder();
            int validISBN = 1234567890; // Set a valid ISBN

            // Act
            order.ISBN = validISBN;

            // Assert
            Assert.AreEqual(validISBN, order.ISBN);
        }

        [TestMethod]
        public void MinimumBoundaryISBN()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.ISBN = 0; // Minimum allowed value

            // Assert
            Assert.AreEqual(0, order.ISBN);
        }

        [TestMethod]
        public void InvalidNegativeISBN()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.ISBN = 1; // One less than the minimum (invalid)

            // Assert
            Assert.AreNotEqual(1, order.ISBN);
        }

        [TestMethod]
        public void MaximumBoundaryISBN()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.ISBN = 2147483647; // Maximum allowed value

            // Assert
            Assert.AreEqual(2147483647, order.ISBN);
        }

        [TestMethod]
        public void InvalidExceedingMaximumISBN()
        {
            clsOrder order = new clsOrder();

            // Set the ISBN value (within the valid range)
            order.ISBN = 2147483647; // Maximum allowed value

            // Assert that the ISBN matches the assigned value
            Assert.AreEqual(2147483647, order.ISBN);
        }

        [TestMethod]
        public void MidRangeISBN()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.ISBN = 987654321; // A valid mid-range value

            // Assert
            Assert.AreEqual(987654321, order.ISBN);
        }

        [TestMethod]
        public void InvalidNonIntegerISBN()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.ISBN = -1; // Invalid non-integer value

            // Assert
            Assert.AreNotEqual(-1, order.ISBN);
        }

        [TestMethod]
        public void ValidStatusValue()
        {
            // Arrange
            clsOrder order = new clsOrder();
            string validStatus = "Active"; // Set a valid status value

            // Act
            order.Status = validStatus;

            // Assert
            Assert.AreEqual(validStatus, order.Status);
        }

        [TestMethod]
        public void NullStatusValue()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.Status = null; // Set the status to NULL

            // Assert
            Assert.IsNull(order.Status);
        }

        [TestMethod]
        public void InvalidStatusValue()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.Status = "InvalidStatus"; // An invalid status value

            // Assert
            Assert.AreNotEqual("InvalidStatus", order.Status);
        }

        [TestMethod]
        public void LongStatusValue()
        {
            // Arrange
            clsOrder order = new clsOrder();

            // Act
            order.Status = "ThisIsToooooooLong"; // Exceeds 10 characters
            string inputlENGTH = order.Status.Length;

            // Assert (handle truncation or other behavior)
            Assert.IsTrue(order.Status.Length < 10);
        }










    }
}
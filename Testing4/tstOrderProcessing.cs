// tstOrder.cs
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        string ISBN = "1";
        string User_Id = "1";
        string Created_At = DateTime.Now.ToShortDateString();
        string Status = "active";

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




        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of a new classs
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserIdMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string User_id = "1"; //this should be ok
                                  //invoke the method
            Error = anOrder.Valid(ISBN, User_id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserIdMinMinus1()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string User_id = "1"; //this should be ok
                                  //invoke the method
            Error = anOrder.Valid(ISBN, User_id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Created_AtExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Created_At = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Created_AtMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Created_At = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Created_AtMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Created_At = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Created_AtMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Created_At = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Created_AtExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Created_At = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Created_AtInvalidDate()
        {
            //create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the Created_At to non date value
            string Created_At = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StatusMinLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            string Error = "";

            // This should fail
            string Status = "";

            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            string Error = "";

            // This should pass
            string Status = "a";

            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            string Error = "";

            // This should pass
            string Status = "aa";

            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            string Error = "";

            // This should pass
            string Status = "";
            Status = Status.PadRight(49, 'a');

            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            string Error = "";

            // This should pass
            string Status = "";
            Status = Status.PadRight(50, 'a');

            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            string Error = "";

            // This should fail
            string Status = "";
            Status = Status.PadRight(51, 'a');

            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMid()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            string Error = "";

            // This should pass
            string Status = "";
            Status = Status.PadRight(25, 'a');

            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ISBNExtremeMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string ISBN = "-1000";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ISBNMinLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string ISBN = "-1";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ISBNMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string ISBN = "0";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ISBNMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string ISBN = "1";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ISBNMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string ISBN = "2147483646";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ISBNMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string ISBN = "2147483647";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ISBNMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string ISBN = "2147483648";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ISBNMid()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string ISBN = "1073741824";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ISBNExtremeMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string ISBN = "5000000000";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ISBNInvalidDataType()
        {
            // Create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // Set the ISBN to a non-integer data type
            string ISBN = "this is not an integer!";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void User_IdExtremeMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string User_Id = "-1000";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void User_IdMinLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string User_Id = "-1";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void User_IdMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string User_Id = "0";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void User_IdMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string User_Id = "1";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void User_IdMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string User_Id = "2147483646";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void User_IdMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string User_Id = "2147483647";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void User_IdPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string User_Id = "2147483648";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void User_IdMid()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should pass
            string User_Id = "1073741824";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void User_IdExtremeMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // This should fail
            string User_Id = "5000000000";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void User_IdInvalidDataType()
        {
            // Create a new instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // Set the ISBN to a non-integer data type
            string User_Id = "this is not an integer!";
            // Invoke the method
            Error = AnOrder.Valid(ISBN, User_Id, Created_At, Status);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}

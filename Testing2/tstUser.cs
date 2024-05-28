using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
        // Good test data
        private string Name = "Test nAME";
        private string Address = "LE1 9HB";
        private string DateCreated = DateTime.Now.Date.ToString();
        private string PhoneNumber = "074828385748";
        private string Role_Name = "nAME";
        private string Role_Id = "1223";


        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "0874637489";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "1234567891";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(17, '2');    //this should fail
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should be ok
            PhoneNumber = PhoneNumber.PadRight(15, '4');    //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should be ok
            PhoneNumber = PhoneNumber.PadRight(16, '4');    //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PhoneNoMid()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should be ok
            PhoneNumber = PhoneNumber.PadRight(8, '4');    //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(11, '4');    //this should fail
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtreme()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(500, '4');    //this should fail
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(19, '4');
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "a";
            PhoneNumber = PhoneNumber.PadRight(10, '4');
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
                                //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(49, 'a');    //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(50, 'a');    //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameNoMid()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(25, 'a');    //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; 
            Name = Name.PadRight(51, 'a');    //this should fail
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(500, 'a');    //this should fail
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMin()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create a varaible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string varaible
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMin()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMax()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateCreated = TestDate.ToString();
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedInvalidDate()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateCreated = "this is not a date!";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddresseMin()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aa";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aaaaaaaa";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aaaaaaaaa";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "aaaaaaaaaa";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aaaa";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Role_Name = "";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoleNameMin()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role_Name = "a";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role_Name = "aa";
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role_Name = "";
            Role_Name = Role_Name.PadRight(49, 'a');
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role_Name = "";
            Role_Name = Role_Name.PadRight(50, 'a');
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoleNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Role_Name = "";
            Role_Name = Role_Name.PadRight(51, 'a');
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Role_Name = "";
            Role_Name = Role_Name.PadRight(25, 'a');
            //invoke the method
            Error = AUser.Valid(DateCreated, Address, Name, PhoneNumber, Role_Name, Role_Id);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            // Create an instance of the class we want to create
            clsUser AUser = new clsUser();
            // String variable to store any error message
            String Error = "";
            // Invoke the method
            Error = AUser.Valid(DateCreated,Address,Name,PhoneNumber,Role_Name,Role_Id);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a Boolean variable to store the results of the validatoin
            Boolean Found = false;
            //create some test data to use with the method
            Int32 UserId = 421;
            //invoke the method
            Found = AUser.Find(UserId);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRole_IdFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 mUserId = 421;
            //invoke the method
            Found = AUser.Find(mUserId);
            //check the address id property
            if (AUser.Role_Id != 421)
            {
                OK = true;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestRole_NameFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 421;
            //invoke the method
            Found = AUser.Find(UserId);
            //check the town property
            if (AUser.Role_Name != "Admin")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 userId = 421;
            //invoke the method
            Found = AUser.Find(userId);
            //check the house no property
            if (AUser.PhoneNumber != "07463525325")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 userId = 421;
            //invoke the method
            Found = AUser.Find(userId);
            //check the street property
            if (AUser.Name != "Henry")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 mUserId = 421;
            //invoke the method
            Found = AUser.Find(mUserId);
            //check the active property
            if (AUser.IsActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 userId = 421;
            //invoke the method
            Found = AUser.Find(userId);
            //check the post code property
            if (AUser.Address != "LE5 1UT")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateCreatedFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 421;
            //invoke the method
            Found = AUser.Find(UserId);
            //check the date added property
            if (AUser.DateCreated != Convert.ToDateTime("12/01/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 421;
            //invoke the method
            Found = AUser.Find(UserID);
            //check the address id property
            if (AUser.UserId != 421)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AUser.IsActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.IsActive, TestData);
        }

        [TestMethod]
        public void DateCreatedPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AUser.DateCreated = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.DateCreated, TestData);
        }


        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserId, TestData);
        }


        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "07928473829";
            //assign the data to the property
            AUser.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.PhoneNumber, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AUser.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Address, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Some Name";
            //assign the data to the property
            AUser.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Name, TestData);
        }


        [TestMethod]

        public void IsRoleIDOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AUser.Role_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Role_Id, TestData);
        }

        [TestMethod]

        public void IsRoleNameOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "User";
            //assign the data to the property
            AUser.Role_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Role_Name, TestData);
        }

    }
}
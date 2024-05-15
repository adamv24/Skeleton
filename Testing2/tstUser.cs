using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
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
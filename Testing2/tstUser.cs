using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstUser
    {
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
            AUser.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AUser.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.AddressId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.AddressId, TestData);
        }

        [TestMethod]
        public void CountyCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.CountyCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.CountyCode, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AUser.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AUser.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AUser.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AUser.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Town, TestData);
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

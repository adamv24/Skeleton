using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;

namespace Testing1
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two vallues are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "Adam";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "password";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "Stock";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Adam";
            string Password = "password";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

    }
}

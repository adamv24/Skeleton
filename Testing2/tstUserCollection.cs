using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstUserCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            //test to see that it exists
            Assert.IsNotNull(AllUser);
        }

        [TestMethod]
        public void UserListOk()
        {
            //create an instance of the class we want to create 
            clsUserCollection AllUser = new clsUserCollection();
            //create some test data to assign to the property
            //in this case the data needsto be a list of objects
            List<clsUser> TestList = new List<clsUser>();   
            //add an item to the list
            //create the item of test data
            clsUser TestItem = new clsUser();
            //set its properties
            TestItem.IsActive = true;
            TestItem.Name = "Test";
            TestItem.Address = "LE2 1HB";
            TestItem.Role_Name = "ADMIN";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateCreated = DateTime.Now;
            TestItem.UserId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllUser.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUser.UserList, TestList);   
        }

        [TestMethod]    
        public void CountPropertyOk()
        {
            //create an instance of the class we want to create
            clsUser AllUser = new clsUser();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllUser.Count = SomeCount;
            //test to see that ttwo values are the same
            Assert.AreEqual(AllUser.Count, SomeCount);
        }
    }
}

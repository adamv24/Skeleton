using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Testing4;

namespace Testing2
{
    [TestClass]
    public class tstUserCollection
    {
        [TestMethod]
        public void InstanceOK()
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

     

        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllUser.Count = SomeCount;
            //test to see that that two values are the saem
            Assert.AreEqual(AllUser.Count, SomeCount);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            //create some test data to assign to the property
            clsUser TestItem = new clsUser();
            //set the properties of the test object
            TestItem.IsActive = true;
            TestItem.Name = "Test";
            TestItem.Address = "LE2 1HB";
            TestItem.Role_Name = "ADMIN";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateCreated = DateTime.Now;
            TestItem.UserId = 1;
            //assign the data to the property
            AllUser.ThisUser = TestItem;
            //test to see that the two values are the same
            Assert.AreEqual(AllUser.ThisUser, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUser = new clsUserCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsUser> TestList = new List<clsUser>();
            //Add an item to the list
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
            //assign the data to the property
            AllUser.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUser.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create the item of test data
            clsUser TestItem = new clsUser();
            //variable to store the primarty key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsActive = true;
            TestItem.Name = "Test";
            TestItem.Address = "LE2 1HB";
            TestItem.Role_Name = "ADMIN";
            TestItem.PhoneNumber = "1234567890";
            TestItem.DateCreated = DateTime.Now;
            TestItem.UserId = 1;
            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUsers.Add();
            //set the primary ket of the test data
            TestItem.UserId = PrimaryKey;
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);

        }
    }
}

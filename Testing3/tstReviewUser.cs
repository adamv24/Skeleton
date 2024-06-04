using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstReviewUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReviewUser anRUser = new clsReviewUser();
            Assert.IsNotNull(anRUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsReviewUser anRUser = new clsReviewUser();
            Int32 TestData = 1;
            anRUser.UserID = TestData;
            Assert.AreEqual(anRUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsReviewUser anRUser = new clsReviewUser();
            string TestData = "Andre";
            anRUser.UserName = TestData;
            Assert.AreEqual(anRUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsReviewUser anRUser = new clsReviewUser();
            string TestData = "ProneDre";
            anRUser.Password = TestData;
            Assert.AreEqual(anRUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsReviewUser anRUser = new clsReviewUser();
            string TestData = "Review Book";
            anRUser.Department = TestData;
            Assert.AreEqual(anRUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsReviewUser anRUSER = new clsReviewUser();
            Boolean Found = false;
            string UserName = "Andre";
            string Password = "ProneDre";
            Found = anRUSER.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsReviewUser anRUser = new clsReviewUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Andre";
            string Password = "ProneDre";
            Found = anRUser.FindUser(UserName, Password);
            if (anRUser.UserName != UserName && anRUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}

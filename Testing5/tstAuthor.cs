using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstAuthor
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsAuthor AnAuthor = new clsAuthor();
            //test to see that it exists
            Assert.IsNotNull(AnAuthor);
        }
    }
}

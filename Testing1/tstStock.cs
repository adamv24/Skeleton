using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a instance of the class we want ot create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }
    }
}

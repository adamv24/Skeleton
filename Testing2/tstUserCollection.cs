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
            clsUserCollection AllUser = new clsUserCollection();
            Assert.IsNotNull(AllUser);
        }
    }
}

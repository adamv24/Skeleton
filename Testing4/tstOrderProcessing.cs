using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderProcessing
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsadress AnAddress = new clsadress();

            Assert.IsNotNull(AnAddress);

        }
    }
}

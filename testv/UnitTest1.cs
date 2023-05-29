using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BUS;
namespace testv
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IBUS_NguoiDung busnd = new BUS_NguoiDung();
            Assert.Equals(-1,busnd.Login("long","123"));
        }
    }
}

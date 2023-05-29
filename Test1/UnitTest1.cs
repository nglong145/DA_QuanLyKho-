using BUS;

namespace Test1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            IBUS_NguoiDung busnd = new BUS_NguoiDung();
            Assert.IsTrue(busnd.Login("long", "123"));
        }
    }
}
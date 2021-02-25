using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBinary4()
        {
            BinaryClass.BinaryConverter p = new BinaryClass.BinaryConverter();
            string expected = "100";
            string actual = p.IntToBinaryString(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBinary2()
        {
            BinaryClass.BinaryConverter p = new BinaryClass.BinaryConverter();
            string expected = "10";
            string actual = p.IntToBinaryString(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBinary1()
        {
            BinaryClass.BinaryConverter p = new BinaryClass.BinaryConverter();
            string expected = "1";
            string actual = p.IntToBinaryString(1);

            Assert.AreEqual(expected, actual);
        }
    }
}

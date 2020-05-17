using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.StringExtensions.UnitTest
{
    [TestClass]
    public class StringExtensionsUnitTest
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            Assert.IsTrue(((string) null).IsNullOrEmpty());
            Assert.IsTrue(string.Empty.IsNullOrEmpty());

            Assert.IsFalse("lorem".IsNullOrEmpty());
        }
    }
}
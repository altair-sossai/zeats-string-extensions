using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.StringExtensions.UnitTest
{
    [TestClass]
    public class IsNullOrEmptyExtensionTest
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            Assert.IsTrue(IsNullOrEmptyExtension.IsNullOrEmpty(null));
            Assert.IsTrue(string.Empty.IsNullOrEmpty());
            Assert.IsFalse("lorem".IsNullOrEmpty());
        }
    }
}
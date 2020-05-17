using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.StringExtensions.UnitTest
{
    [TestClass]
    public class RemoveDiacriticsExtensionTest
    {
        [TestMethod]
        public void RemoveDiacritics()
        {
            Assert.IsNull(RemoveDiacriticsExtension.RemoveDiacritics(null));
            Assert.AreEqual(string.Empty, string.Empty.RemoveDiacritics());
            Assert.AreEqual("Lorem Ipsum", "Lorem Ipsum".RemoveDiacritics());
            Assert.AreEqual("aA eE iI oO uU", "áÁ éÉ íÍ óÓ úÚ".RemoveDiacritics());
        }
    }
}
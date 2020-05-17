using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.StringExtensions.UnitTest
{
    [TestClass]
    public class SlugExtensionTest
    {
        [TestMethod]
        public void Slug()
        {
            const int maxLength = 100;

            Assert.IsNull(SlugExtension.Slug(null, maxLength));
            Assert.AreEqual(string.Empty, string.Empty.Slug(maxLength));
            Assert.AreEqual("lorem-ipsum", "Lorem Ipsum".Slug(maxLength));
            Assert.AreEqual("aa-ee-ii-oo-uu", "áÁ éÉ íÍ óÓ úÚ".Slug(maxLength));
        }

        [TestMethod]
        public void SlugWithMaxLength()
        {
            const int maxLength = 6;

            Assert.IsNull(SlugExtension.Slug(null, maxLength));
            Assert.AreEqual(string.Empty, string.Empty.Slug(maxLength));
            Assert.AreEqual("lorem", "Lorem Ipsum".Slug(maxLength));
            Assert.AreEqual("aa-ee", "áÁ éÉ íÍ óÓ úÚ".Slug(maxLength));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SlugWithInvalidMaxLength()
        {
            const int maxLength = 0;

            Assert.AreEqual("lorem", "Lorem Ipsum".Slug(maxLength));
        }
    }
}
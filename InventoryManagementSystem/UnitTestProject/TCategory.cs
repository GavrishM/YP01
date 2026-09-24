using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class TCategory
    {
        [TestMethod]
        public void TestConstructor()
        {
            int id = 1;
            string name = "Fish";

            int expectedId = id;
            string expectedName = name;

            Category category = new Category(id, name);

            Assert.AreEqual(expectedId, category.Id);
            Assert.AreEqual(expectedName, category.Name);
        }
    }
}

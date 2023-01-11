using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week4LabProgramQuestion;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Shapes circle = new Shapes(4.0);
            Shapes rectangle = new Shapes(5.0, 4.0);

            Assert.AreEqual(rectangle.RectangleArea(), 21f);
        }
    }
}

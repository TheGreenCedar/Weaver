using NUnit.Framework;
using System.Linq;
using Weaver.Shared.JournalComponents;

namespace WeaverTests
{
    public class JGridTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetNextPoint()
        {
            Assert.AreEqual((2, 1), JGrid.GetNextPoint(1, 5, 5));
            Assert.AreEqual((2, 2), JGrid.GetNextPoint(2, 1, 5));
            Assert.AreEqual((1, 2), JGrid.GetNextPoint(1, 1, 2));
        }
        [Test]
        public void FillEmpty()
        {
            Assert.AreEqual(0, JGrid.FillWithEmpty(1, 1, 1, 2, 5, 12).Count());
            Assert.AreEqual(2, JGrid.FillWithEmpty(1, 1, 1, 4, 5, 12).Count());
            Assert.AreEqual(3, JGrid.FillWithEmpty(1, 1, 1, 5, 5, 12).Count());
            Assert.AreEqual(4, JGrid.FillWithEmpty(1, 1, 2, 1, 5, 12).Count());
            Assert.AreEqual(5, JGrid.FillWithEmpty(1, 1, 2, 2, 5, 12).Count());
            Assert.AreEqual(13, JGrid.FillWithEmpty(1, 4, 4, 3, 5, 12).Count());
            Assert.AreEqual(5, JGrid.FillWithEmpty(5, 1, 11, 1, 1, 12).Count());
        }
    }
}
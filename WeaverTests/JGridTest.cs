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
        public void RowColFromId()
        {
            Assert.AreEqual((2, 4), JGrid.RowFromId("cell2_4"));
            Assert.AreEqual((12, 4), JGrid.RowFromId("cell12_4"));
            Assert.AreEqual((12, 40), JGrid.RowFromId("cell12_40"));
            Assert.AreEqual((1, 10), JGrid.RowFromId("cell1_10"));
        }
    }
}
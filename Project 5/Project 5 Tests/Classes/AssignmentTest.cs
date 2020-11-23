using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_5;

namespace Project_5_Tests
{
    [TestClass]
    public class AssignmentTest
    {
        [TestMethod]
        public void GettersAndSetters()
        {
            Assignment assignmentActual = new Assignment("John Doe", 5, 10);

            Assert.AreEqual("John Doe", assignmentActual.Name);
            Assert.AreEqual(5, assignmentActual.PointsEarned);
            Assert.AreEqual(10, assignmentActual.PointsPossible);
        }
    }
}

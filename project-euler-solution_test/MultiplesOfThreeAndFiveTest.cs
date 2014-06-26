using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using project_euler_solution;

namespace project_euler_solution_test
{
    [TestClass]
    public class MultiplesOfThreeAndFiveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(233168, new MultiplesOfThreeAndFive().solucionar());
        }
    }
}

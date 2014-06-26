using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using project_euler_solution;

namespace project_euler_solution_test
{
    [TestClass]
    public class MultiplesOfThreeAndFiveTest
    {
        [TestMethod]
        public void TestSolucionarMatematica()
        {
            Assert.AreEqual(233168, new MultiplesOfThreeAndFive().solucionarMatematica());
        }

        [TestMethod]
        public void TestSolucionarLoop1()
        {
            Assert.AreEqual(233168, new MultiplesOfThreeAndFive().solucionarLoop1());
        }

        [TestMethod]
        public void TestSolucionarLoop2()
        {
            Assert.AreEqual(233168, new MultiplesOfThreeAndFive().solucionarLoop2());
        }

        [TestMethod]
        public void TestSolucionarLoop3()
        {
            Assert.AreEqual(233168, new MultiplesOfThreeAndFive().solucionarLoop3());
        }

    }
}

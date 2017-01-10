using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Project
{
    [TestClass]
    public class Tests
    {
        [TestCategory("Language Knowledge"), TestMethod]
        public void Test1()
        {
            Check.That(Solution.Test(1, 5)).IsTrue();
        }

        [TestCategory("Language Knowledge"), TestMethod]
        public void Test2()
        {
            Check.That(Solution.Test(5, 1)).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Test3()
        {
            Check.That(Solution.Test(2, 3)).IsFalse();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Test4()
        {
            Check.That(Solution.Test(3, 2)).IsFalse();
        }

        [TestCategory("Language Knowledge"), TestMethod]
        public void Test5()
        {
            Check.That(Solution.Test(-3, 4)).IsTrue();
        }

        [TestCategory("Language Knowledge"), TestMethod]
        public void Test6()
        {
            Check.That(Solution.Test(4, -3)).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Test7()
        {
            Check.That(Solution.Test(0, 0)).IsFalse();
        }
    }
}
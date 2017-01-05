using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace Project
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1()
        {
            Check.That(Solution.Test(1, 5)).IsTrue();
        }

        [TestMethod]
        public void Test2()
        {
            Check.That(Solution.Test(2, 3)).IsFalse();
        }

        [TestMethod]
        public void Test3()
        {
            Check.That(Solution.Test(-3, 4)).IsTrue();
        }
    }
}
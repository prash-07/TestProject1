
using NUnit.Framework;
using Assignment5;
namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        SavingsAccount obj = new SavingsAccount(1050218, 50000, "plpk", 1000);
        [Test]
        public void TestMethod1()
        {
            int actual = obj.Add(25, 34);
            Assert.AreEqual(59, actual);
        }

        [Test]
        public void TestMethod2()
        {
            int actual = obj.Withdraw(20000);
            Assert.AreEqual(30000, actual);
        }

        [Test]
        public void TestMethod3()
        {
            int actual = obj.Withdraw(20000);
            Assert.AreEqual(10000, actual);
        }
    }
}

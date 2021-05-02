using NUnit.Framework;

namespace MoneyExample.Tests
{
    [TestFixture]
    public class TestCase
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equals(10, five.amount);
        }
    }
}

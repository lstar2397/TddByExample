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
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.amount);
        }
    }
}

using NUnit.Framework;
using ChangeCalculator;

namespace ChangeCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPaymentValidTest()
        {
            ChangeCalculator calc = new ChangeCalculator();
            Assert.Pass();
        }
    }
}
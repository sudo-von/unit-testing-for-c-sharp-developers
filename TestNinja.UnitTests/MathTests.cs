using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        // TearDown
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            int result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1 ,2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            int result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Max_SecondrgumentIsGreater_ReturnTheSecondArgument()
        {
            int result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Because i wanted to!")]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            int result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreatherThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
            /* General
            * Assert.That(result, Does.Contain(1));
            * Assert.That(result, Does.Contain(3));
            * Assert.That(result, Does.Contain(5));
            * Assert.That(result, Is.Not.Empty);
            * Assert.That(result, Is.Ordered);
            * Assert.That(result, Is.Unique);
            */
        }
    }
}

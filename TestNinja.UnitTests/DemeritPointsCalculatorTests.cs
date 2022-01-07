using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(1, 0, TestName = "SpeedIsLessThanSpeedLimit")]
        [TestCase(70, 1, TestName = "ResultIsCalculatedByDemeritPoints")]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var points = demeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(points, Is.EqualTo(expectedResult));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsLessThanZero_ReturnArgumentOutOfRangeException()
        {
            var calculator = new DemeritPointsCalculator();
            Assert.That(() => calculator.CalculateDemeritPoints(-1),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}

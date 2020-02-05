using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorLab.Test.Unit
{
    [TestFixture]
    public class CalculatorLabTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }
        // A little change 

        [TestCase(5.0, 10.0, 15.0)]
        [TestCase(-5.0, -10.0, -15.0)]
        [TestCase(5.0, -10.0, -5.0)]
        [TestCase(0, 0, 0)]
        public void Add_AddTwoDoubles_ReturnCorrectValue(double a, double b, double expected)
        {
            // Arrange is Setup
            //var uut = new Calculator();

            // Act
            var result = uut.Add(a, b);

            // Assert
            // Constraint-based model
            Assert.That(result, Is.EqualTo((expected)));
        }

        [Test]
        public void Subtract_SubtractTwoDoubles_ReturnCorrectValue()
        {
            var result = uut.Subtract(19, 10);

            // Classic assert model
            Assert.AreEqual(9, result);
        }

        [TestCase(5.0, 10.0, -5.0)]
        [TestCase(-5.0, -10.0, 5.0)]
        [TestCase(5.0, -10.0, 15.0)]
        [TestCase(0, 0, 0)]
        public void Subtract_SubtractTwoDoubles_ReturnCorrectValueMultipleCases(double a, double b, double expected)
        {
            var result = uut.Subtract(a, b);

            Assert.That(result, Is.EqualTo((expected)));
        }

        [TestCase(5.0, 10.0, 50)]
        [TestCase(-5.0, -10.0, 50)]
        [TestCase(5.0, -10.0, -50)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyTwoDoubles_ReturnCorrectValue(double a, double b, double expected)
        {
            var result = uut.Multiply(a, b);

            Assert.That(result, Is.EqualTo((expected)));
        }

        [TestCase(2.0, 3.0, 8.0)]
        [TestCase(-5.0, -2.0, 0.04)]
        [TestCase(3.0, -2.0, 0.11111111111)]
        [TestCase(0, 0, 1)]
        public void Power_PowerTwoDoubles_ReturnCorrectValue(double a, double b, double expected)
        {
            var result = uut.Power(a, b);

            Assert.That(result, Is.EqualTo((expected)).Within(0.001));
        }

        [TestCase(2.0, 2.0, 1.0)]
        [TestCase(-2.0, -2.0, 1.0)]
        [TestCase(-10.0, 5.0, -2.0)]
        public void Divide_DivideTwoDoubles_ReturnCorrectValue(double a, double b, double expected)
        {
            var result = uut.Divide(a, b);                 //Act
            Assert.That(result, Is.EqualTo(expected)); //Assert
        }

        [Test]
        public void Divide_DivideByZero_ThrowException()
        {
            var expected = Assert.Throws<DivisionException>(() => uut.Divide(10.0, 0.0));
        }

        [Test]
        public void Clear_ClearAccumalator_AccumalatorCleared()
        {
            uut.Clear();
            Assert.AreEqual(uut.Accumulator, 0);
        }

        [TestCase(2.0, 3.0, 8.0)]
        [TestCase(-5.0, -2.0, 0.04)]
        [TestCase(3.0, -2.0, 0.11111111111)]
        [TestCase(0, 0, 1)]
        public void Accumulator_DoPowerOperation_AssertCorrectValue(double a, double b, double expected)
        {
            var result = uut.Power(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo((expected)).Within(0.001));
        }

        [TestCase(5.0, 10.0, 50)]
        [TestCase(-5.0, -10.0, 50)]
        [TestCase(5.0, -10.0, -50)]
        [TestCase(0, 0, 0)]
        public void Accumulator_DoMultiplyOperation_AssertCorrectValue(double a, double b, double expected)
        {
            var result = uut.Multiply(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo((expected)));
        }

        [TestCase(5.0, 10.0, -5.0)]
        [TestCase(-5.0, -10.0, 5.0)]
        [TestCase(5.0, -10.0, 15.0)]
        [TestCase(0, 0, 0)]
        public void Accumulator_DoSubtractOperation_AssertCorrectValue(double a, double b, double expected)
        {
            var result = uut.Subtract(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo((expected)));
        }

        [TestCase(5.0, 10.0, 15.0)]
        [TestCase(-5.0, -10.0, -15.0)]
        [TestCase(5.0, -10.0, -5.0)]
        [TestCase(0, 0, 0)]
        public void Accumulator_DoAddOperation_AssertCorrectValue(double a, double b, double expected)
        {
            var result = uut.Add(a, b);

            Assert.That(uut.Accumulator, Is.EqualTo((expected)));
        }
    }
}

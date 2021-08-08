using NUnit.Framework;
using Calculator_Model;
using System;

namespace CalculatorTest
{
    public class IntergerCalc_Test
    {

        public class SimpleCalculatorTest 
        {

            Calculator _calculator;

            [SetUp]
            public void Setup()
            {

                _calculator = new Calculator();

            }

            // add

            [TestCase(2.5, 7.4, 9.9)]
            [TestCase(2, 7, 9)]
            [TestCase(5, 4, 9)]
            [TestCase(25, 74, 99)]
            public void WhenSetUpWithTwoDoubles_Add_ReturnsCorrectAnswer(double num1, double num2, double expected)
            {
                _calculator.Num1 = num1;
                _calculator.Num2 = num2;
                
                Assert.That(_calculator.Add(), Is.EqualTo(expected));
            }


            // multiply

            [TestCase(2, 7, 14)]
            [TestCase(2.5, 2, 5)]
            [TestCase(5, 4, 20)]
            [TestCase(25, 0, 0)]
            public void WhenSetUpWithTwoDoubles_Multiply_ReturnsCorrectAnswer(double num1, double num2, double expected)
            {
                _calculator.Num1 = num1;
                _calculator.Num2 = num2;

                Assert.That(_calculator.Multiply(), Is.EqualTo(expected));
            }

            // subtract 

            [TestCase(2, 7, -5)]
            [TestCase(2.5, 2, 0.5)]
            [TestCase(5, 4, 1)]
            [TestCase(25, 5, 20)]
            public void WhenSetUpWithTwoDoubles_Subtract_ReturnsCorrectAnswer(double num1, double num2, double expected)
            {
                _calculator.Num1 = num1;
                _calculator.Num2 = num2;

                Assert.That(_calculator.Subtract(), Is.EqualTo(expected));
            }

            // divide
            [TestCase(2, 2, 1)]
            [TestCase(25, 5, 5)]
            [TestCase(5, 1, 5)]
            [TestCase(42, 20, 2.1d)]
            public void WhenSetUpWithTwoDoubles_Divide_ReturnsCorrectAnswer(double num1, double num2, double expected)
            {
                _calculator.Num1 = num1;
                _calculator.Num2 = num2;

                Assert.That(_calculator.Divide(), Is.EqualTo(expected));
            }

            // divide by zero

            [Test]
            public void When_MultiplyByZero_ReturnsException()
            {
                _calculator.Num1 = 5;
                _calculator.Num2 = 0;

                Assert.That(()=> _calculator.Divide(), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("Cant divide by 0"));
            }

        }


    }
}
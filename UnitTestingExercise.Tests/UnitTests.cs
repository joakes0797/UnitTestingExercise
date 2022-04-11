using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 0, 2, 3)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-2, -2, -2, -6)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var addTest = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = addTest.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]//Add test data <-------
        [InlineData(0, 0, 0)]
        [InlineData(5, 6, -1)]
        [InlineData(-4, -6, 2)]
        public void SubtractTest(int minuend, int subtrahend, int difference)
        {
            //Start Step 5 here:

            //Arrange
            var subTest = new Calculator();

            //Act
            var actual = subTest.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(difference, actual);

        }

        [Theory]
        [InlineData(1, 1, 1)]//Add test data <-------
        [InlineData(7, 0, 0)]
        [InlineData(5, 4, 20)]
        [InlineData(9, -9, -81)]

        public void MultiplyTest(int multiplicand, int multiplier, int product)
        {
            //Start Step 7 here:

            //Arrange
            var multTest = new Calculator();

            //Act
            var actual = multTest.Multiply(multiplicand, multiplier);

            //Assert
            Assert.Equal(product, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(10, -1, -10)]
        [InlineData(25, 5, 5)]
        [InlineData(3, 2, 1)]
        public void DivideTest(int dividend, int divisor, int quotient)
        {
            //Arrange
            var divTest = new Calculator();

            //Act
            var actual = divTest.Divide(dividend, divisor);

            //Assert
            Assert.Equal(quotient, actual);

        }

    }
}

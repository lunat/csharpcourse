using System;
using CalculatorLib;
using Xunit;

namespace CalculatorLibTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnFour_WhenAddingTwoAndTwo()
        {
            //Arrange
            decimal a = 2m;
            decimal b = 2m;
            decimal expected = 4m;
            var sut = new Calculator();

            //Act
            decimal actual = sut.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_ShouldReturnFive_WhenAddingTwoAndThree()
        {
            //Arrange
            decimal a = 2m;
            decimal b = 3m;
            decimal expected = 5m;
            var sut = new Calculator();

            //Act
            decimal actual = sut.Add(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ShouldThrowException_WhenSecondNumberIsZero()
        {
            //Arrange
            int a = 2;
            int b = 0;
            var sut = new Calculator();

            //Act Assert
            Assert.Throws<DivideByZeroException>(() => sut.Divide(a, b));
        }
    }
}
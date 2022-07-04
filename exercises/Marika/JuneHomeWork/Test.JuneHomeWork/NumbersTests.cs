using JuneHomeWork.Helpers;
using Xunit;

namespace Test.JuneHomeWork
{
    public class NumbersTests
    {
        [Fact]
        public void Add_ShouldReturnTen_WhenAddingThreeAndSeven() 
        {
            // Arrange
            decimal a = 3m;
            decimal b = 7m;
            decimal expected = 10m;

            // Act
            decimal actual = Numbers.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
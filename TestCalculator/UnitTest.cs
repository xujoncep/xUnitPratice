
using CalculatorApp;
using NSubstitute;

namespace TestCalculator
{
    public class UnitTest
    {
        [Fact]
        public void Addition_TwoIntNumber_Sum()
        {
            //arrange
            var cal = new Calculator();
            int a = 4;
            int b = 2;
            int expected = 6;

            //act
            int result = cal.Addition(a, b);

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Substraction_TwoIntNumber_Substraction()
        {
            //arrange
            var cal = new Calculator();
            int a = 40;
            int b = 38;
            int expected = 2;

            //act
            int result = cal.Subtraction(a, b);

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Multiplication_TwoIntNumber_Multiplication()
        {
            //arrange
            var cal = new Calculator();
            int a = 4;
            int b = 8;
            int expected = 32;

            //act
            int result = cal.Multiplication(a, b);

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void  Divison_TwoNonZeroNumber_DivisionResult()
        {
            //arrange
            var cal = new Calculator();
            int a = 4;
            int b = 2;
            int expected = 2;

            //act
            int result = cal.Divison(a, b);

            //Assert
            Assert.Equal(expected, result);

        }


        [Fact]
        public void Divison_OneZeroNumber_ThrowException()
        {
            //arrange
            var cal = new Calculator();
            int a = 4;
            int b = 0;
            string expected = "Divisor cannot be zero";

            //act and assert
            var result = Assert.Throws<Exception>( ()  => cal.Divison(a, b));

            // assert 
            Assert.Equal(expected, result.Message);

        }

        [Fact]
        public void GetGreeting_NoInput_ReturnsHelloWorld()
        {
            // Arrange
            var greeter = new Greeter();

            // Act
            var result = greeter.GetGreeting();

            // Assert
            Assert.Equal("Hello, World!", result);
        }


    }
}
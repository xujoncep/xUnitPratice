
using CalculatorApp;
using NSubstitute;

namespace TestCalculator
{
    public class UnitTest
    {
        [Fact]

        public void Addition_TwoIntNumber_SumOfTwoNumber()
        {
            //arrange
            var cal = Substitute.For <ICalculator> ();
            int a = -4;
            int b = -3;
            int c = -7;
            cal.Addition(a, b).Returns(-7); //mocking 
            
            //act
            int res = cal.Addition(a, b);
            
            //Assert
            Assert.Equal(c, res);

        }


        [Fact]

        public void Substraction_TwoPositiveNumber_Sub()
        {
            //arrange
            var cal = Substitute.For<ICalculator>();
            int a = 4;
            int b = 3;
            int c = 1;
            cal.Subtraction(a, b).Returns(1); //mocking
            
            //act
            int res = cal.Subtraction(a, b);

            //Assert
            Assert.Equal(c, res);

        }

        [Fact]

        public void Multiplication_TwoPositiveNumber_MultiplicationResult()
        {
            //arrange
            var cal = Substitute.For<ICalculator>();
            int a = 4;
            int b = 3;
            int c = 1;
            cal.Subtraction(a, b).Returns(1); //mocking

            //act
            int res = cal.Subtraction(a, b);

            //Assert
            Assert.Equal(c, res);

        }


        [Fact]

        public void  Divison_TwoNonZeroNumber_DivisionResult()
        {
            //arrange
            var cal = new Calculator();
            int a = 4;
            int b = 2;
            int c = 2;

            //act
            int res = cal.Divison(a, b);

            //Assert
            Assert.Equal(c, res);

        }

        [Fact]
        public void Divison_OneZeroNumber_ThrowException()
        {
            //arrange
            var cal = new Calculator();
            int a = 4;
            int b = 0;
            string c = "Divisor cannot be zero";

            //act and assert
            var result = Assert.Throws<Exception>( ()  => cal.Divison(a, b));

            // assert 
            Assert.Equal(c, result.Message);

        }
    }
}
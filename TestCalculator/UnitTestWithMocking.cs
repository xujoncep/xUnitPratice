using CalculatorApp;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public class UnitTestWithMocking
    {
        [Fact]
        public void Addition_TwoIntNumber_SumOfTwoNumber()
        {
            //arrange
            var cal = Substitute.For<ICalculator>();
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
            int c = 12;
            cal.Multiplication(a, b).Returns(12); //mocking

            //act
            int res = cal.Multiplication(a, b);

            //Assert
            Assert.Equal(c, res);

        }
    }
}

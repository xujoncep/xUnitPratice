using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public class UnitTestTheory
    {
        [Theory]
        [InlineData(1, 4, 5)]
        [InlineData(-1, 4, 3)]
        [InlineData(-4, 4, 0)]
        [InlineData(100, 4, 104)]
        public void Addition_TwoNonZeroNumber_AdditionResult(int a, int b, int c)
        {
            //arrange
            var cal = new Calculator();

            //act
            int res = cal.Addition(a, b);

            //Assert
            Assert.Equal(c, res);

        }

    }
}

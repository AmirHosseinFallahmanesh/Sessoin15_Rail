using Demo.ApplicationService;
using System;
using Xunit;

namespace Demo.ApplicatoinServiceTest
{
    public class CalculatorTest
    {

        [Trait("calulator","sum")]
        [Fact]
        public void ShoudReturn5WhenInput2and3()
        {
            Calculator calculator = new Calculator();
            int result=calculator.Sum(2, 3);
            Assert.Equal(5, result);

        }


        [Trait("calulator", "sum")]

        [Fact]
        public void ShoudReturn10WhenInput7and3()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sum(7, 3);
            Assert.Equal(10, result);

        }



        [Trait("calulator", "divide")]
        [Fact]
        public void ShouldReturn6WhenInput36and6()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(36, 6);
            Assert.Equal(6, result);
        }

        [Trait("calulator", "divide")]
        [Fact]
        public void ShouldThrowWhenInput0()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(()=> calculator.Divide(12, 0));


        }




    }
}

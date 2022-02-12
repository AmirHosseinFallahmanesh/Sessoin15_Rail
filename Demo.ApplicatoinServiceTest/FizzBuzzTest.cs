using Demo.ApplicationService;
using Xunit;

namespace Demo.ApplicatoinServiceTest
{
    public class FizzBuzzTest
    {

        [Fact]

        [Trait("fizbuzz", "Run")]
        public void ShouldReturn1WhenInput1()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result=fizzBuzz.Run(1);
            Assert.Equal("1", result);
        }

        [Fact]

        [Trait("fizbuzz", "Run")]
        public void ShouldReturn2WhenInput2()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Run(2);
            Assert.Equal("2", result);
        }

        [Fact]
        
        [Trait("fizbuzz", "Run")]
        public void ShouldReturnFizzWhenInput3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Run(3);
            Assert.Equal("fizz", result);
        }


        [Fact]

        [Trait("fizbuzz", "Run")]
        public void ShouldReturnFizzWhenInput6()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Run(6);
            Assert.Equal("fizz", result);
        }

        [Fact]

        [Trait("fizbuzz", "Run")]
        public void ShouldReturnbuzzWhenInput5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Run(5);
            Assert.Equal("buzz", result);
        }


        [Fact]

        [Trait("fizbuzz", "Run")]
        public void ShouldReturnbuzzWhenInput10()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Run(10);
            Assert.Equal("buzz", result);
        }

        [Fact]

        [Trait("fizbuzz", "Run")]
        public void ShouldReturnfizzbuzzWhenInput15()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Run(15);
            Assert.Equal("fizz buzz", result);
        }


        [Fact]

        [Trait("fizbuzz", "Run")]
        public void ShouldReturnfizzbuzzWhenInput30()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Run(30);
            Assert.Equal("fizz buzz", result);
        }
    }
}

using Assignment7.Classes;

namespace FineCalculatorTests
{
    public class FineCalculatorTests
    {
        private readonly FineCalculator calculator;
        public FineCalculatorTests()
        {
            calculator = new FineCalculator();
        }
        [Fact]
        public void Add_ShouldReturnCorrectSumm()
        {
            int a = 10; int b = 5;
            int result = calculator.Add(a, b);
            Assert.Equal(15, result);
        }

        [Fact]
        public void Add_ShouldReturnNotEqual()
        {
            int a = 10; int b = 5;
            int result = calculator.Add(a, b);
            Assert.NotEqual(20, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int a = 10; int b = 5;
            int result = calculator.Subtract(a, b);
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(2,5,10)]
        [InlineData(4,5,20)]
        [InlineData(6,5,30)]
        public void Multiply_ShouldReturnCorrectEqual(int a ,int b ,int expect)
        {
            int result = calculator.Multiply(a,b);
            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(4, 5, 9)]
        [InlineData(6, 5, 11)]
        public void Multiply_ShouldReturnNotEqual(int a, int b , int Notexpect)
        {
            int result = calculator.Multiply(a, b);
            Assert.NotEqual(Notexpect, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            int a = -10, b = 0;
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b)); 
        }
    }
}

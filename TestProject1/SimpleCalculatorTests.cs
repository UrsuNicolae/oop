using ConsoleApp1.UTs;

namespace TestProject1
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void TestAddMethodSholdSumParameters()
        {
            //arange
            var calculator = new SimpleCalculator();

            //act
            var result = calculator.Add(1, 1);

            //assert
            Assert.Equal(2, result);
        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, -1)]
        [InlineData(2, 2, 0)]
        [InlineData(0, 1, -1)]
        public void TestSubtractMethodSholdSubtractFromFirst(int first, int second, int expected)
        {
            //arange
            var calculator = new SimpleCalculator();

            //act
            var result = calculator.Subtract(first, second);

            //assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(0, 1, 0)]
        [InlineData(5, 5, 25)]
        public void TestMultiplyMethodSholdMultiplyParams(int first, int second, int expected)
        {
            //arange
            var calculator = new SimpleCalculator();

            //act
            var result = calculator.Mulitply(first, second);

            //assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(2, 2, 1)]
        [InlineData(0, 1, 0)]
        public void TestDivideMethodSholdDivideFirstParamBySecond(int first, int second, int expected)
        {
            //arange
            var calculator = new SimpleCalculator();

            //act
            var result = calculator.Divide(first, second);

            //assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void TestDivideMethodSholdThrowArgumentExceptionWhenDivideByZero()
        {
            //arange
            var calculator = new SimpleCalculator();


            //assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(12, 0));
        }
    }
}
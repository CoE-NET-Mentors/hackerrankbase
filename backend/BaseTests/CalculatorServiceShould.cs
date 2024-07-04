using BaseTestAPI.Services;

namespace BaseTests
{
    public class CalculatorServiceShould
    {
        [Theory]
        [InlineData(1,1,1,3)]
        public void SumNumbers(int a,int b, int c, int expected)
        {
            var sut = new CalculatorService();

            var actual = sut.Sum(a, b, c);
            Assert.Equal(expected, actual);
        }
    }
}

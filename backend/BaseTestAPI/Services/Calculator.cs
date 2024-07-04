namespace BaseTestAPI.Services
{
    public class CalculatorService
    {
        public int Sum(params int[] operators)
        {
            return operators.Sum();
        }
    }
}

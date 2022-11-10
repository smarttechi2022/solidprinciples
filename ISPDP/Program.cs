namespace ISPDP
{

    public interface IProductPriceCommonCalculator
    {
        decimal ServiceTax();
    }

    public interface IProductPriceCommonCalculatorWithinIndia
    {
        decimal CalculteGST();
    }

    public interface IProductPriceCalculatorOutsideIndia
    {
        decimal CalculteVAT();
    }
    public class CountryIndiaCalculation : IProductPriceCommonCalculator, IProductPriceCommonCalculatorWithinIndia
    {
        public decimal CalculteGST()
        {
            return 200 % 10;
        }

        public decimal ServiceTax()
        {
            throw new NotImplementedException();
        }
    }

    public class CountryOutsideIndiaCalculation : IProductPriceCommonCalculator, IProductPriceCalculatorOutsideIndia
    {
        public decimal CalculteVAT()
        {
            return 200 % 4;
        }

        public decimal ServiceTax()
        {
            return 2000 % 4;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
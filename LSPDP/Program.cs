namespace LSPDP
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string? Location { get; set; }
    }

    public abstract class CalculateTotal
    {
        private readonly List<Product> _ProductsTotal;

        public CalculateTotal(List<Product> products)
        {
            _ProductsTotal = products;
        }
        public abstract int CalculateProducts();
    }

    public class TotalProdctsSold : CalculateTotal
    {
        private readonly List<Product> _ProductsTotal;
        public TotalProdctsSold(List<Product> products) : base(products)
        {
            _ProductsTotal = products;
        }

        public override int CalculateProducts()
        {
            return _ProductsTotal.Count;
        }
    }

    public class TotalProdctsSoldWithinIndia : CalculateTotal
    {
        private readonly List<Product> _ProductsTotal;
        public TotalProdctsSoldWithinIndia(List<Product> products) : base(products)
        {
            _ProductsTotal = products;
        }

        public override int CalculateProducts()
        {
            return _ProductsTotal.Select(p=> p.Location == "India").Count();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName = "BlueTooth Mike", Location= "India", ProductPrice = 12000, Quantity =1 },
                new Product{ProductId = 1, ProductName = "Mouse", Location= "India", ProductPrice = 12000, Quantity =1 },
                new Product{ProductId = 1, ProductName = "PC Monitor", Location= "USA", ProductPrice = 12000, Quantity =1 },
                new Product{ProductId = 1, ProductName = "Keyboard", Location= "UK", ProductPrice = 12000, Quantity =1 },

            };

            CalculateTotal calclateTotal = new TotalProdctsSold(products);
            calclateTotal.CalculateProducts();

            CalculateTotal totalProdctsSoldWithinIndia = new TotalProdctsSoldWithinIndia(products);
            totalProdctsSoldWithinIndia.CalculateProducts();

        }
    }
}
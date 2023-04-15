namespace delegates
{
    internal class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();
            Console.WriteLine($"The total for the cart is {cart.GenarateTotal(SubTotalAlert, CalcukateLeveledDiscount, AlertUser)}");
            Console.WriteLine();

            decimal total = cart.GenarateTotal((subTotal) => Console.WriteLine($"The subtotal for cart 2 is {subTotal}"),
            (products, subTotal) =>
            {
                if (products.Count > 3)
                {
                    return subTotal * 0.5M;
                }
                else
                {
                    return subTotal;
                }
            },
            (message) =>Console.WriteLine($"cart 2 Alert: {message}"));

            Console.WriteLine($"The total for cart 2 is {total}");

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal}");
        }
        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }
        private static decimal CalcukateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {

            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.95M;
            }
            else
            {
                return subTotal;
            }

        }
        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
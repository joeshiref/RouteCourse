using Day_01_G01;
namespace C43_G02_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Restriction Operators

            #region Question 1
            //var outOfStockProducts = ListGenerator.ProductList
            //.Where(p => p.UnitsInStock == 0)
            //.ToList();

            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName} is out of stock.");
            //}
            #endregion

            #region Question 2
            //var productsInStockAndWithPrice = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.0m).ToList();
            //foreach (var product in productsInStockAndWithPrice)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}");
            //}
            #endregion

            #region Question 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var shortDigitNames = Arr
            //    .Where((name, index) => name.Length < index)
            //    .ToList();
            //foreach (var item in shortDigitNames)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            // LINQ – Transformation Operators

            #region Question 1
            //var productNames = ListGenerator.ProductList
            //    .Select(p => p.ProductName)
            //    .ToList();

            //foreach (var item in productNames)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var upperLowerWords = words
            //    .Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() })
            //    .ToList();
            //foreach (var item in upperLowerWords)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //}
            #endregion

            #region Question 3
            //var productPrices = ListGenerator.ProductList
            //    .Select(p => new { p.ProductName, Price = p.UnitPrice })
            //    .ToList();
            //foreach (var item in productPrices)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.Price}");
            //}
            #endregion

            #region Question 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr
            //    .Select((value, index) => new { Value = value, Index = index })
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Value}: {item.Value == item.Index}");
            //}
            #endregion

            #region Question 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = numbersA
            //    .SelectMany(a => numbersB.Where(b => a < b), (a, b) => new { a, b })
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"a: {item.a}, b: {item.b}");
            //}
            #endregion

            #region Question 6

            //var orders = new List<Order>
            //    {
            //    new Order { OrderID = 1, OrderDate = DateTime.Now, Total = 100.00m },
            //    new Order { OrderID = 2, OrderDate = DateTime.Now, Total = 200.00m },
            //    new Order { OrderID = 3, OrderDate = DateTime.Now, Total = 300.00m },
            //    new Order { OrderID = 4, OrderDate = DateTime.Now, Total = 400.00m },
            //    new Order { OrderID = 5, OrderDate = DateTime.Now, Total = 500.00m },
            //};
            //var result = orders
            //    .Where(o => o.Total < 500.00m)
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"OrderID: {item.OrderID}, Total: {item.Total}");
            //}
            #endregion

            #region Question 7
            //var orders = new List<Order>
            //{
            //    new Order { OrderID = 1, OrderDate = new DateTime(1997, 1, 1), Total = 100.00m },
            //    new Order { OrderID = 2, OrderDate = new DateTime(1998, 1, 1), Total = 200.00m },
            //    new Order { OrderID = 3, OrderDate = new DateTime(1999, 1, 1), Total = 300.00m },
            //    new Order { OrderID = 4, OrderDate = new DateTime(2000, 1, 1), Total = 400.00m },
            //    new Order { OrderID = 5, OrderDate = new DateTime(2001, 1, 1), Total = 500.00m },
            //};
            //var result = orders
            //    .Where(o => o.OrderDate.Year >= 1998)
            //    .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"OrderID: {item.OrderID}, OrderDate: {item.OrderDate}");
            //}
            #endregion

        }
    }
}

namespace ConsoleNorthwind
{
    using System;
    using System.Linq;
     static class Program
    {
        static void Main()
        {
            using (var db = new NorthwindDbContext())
            {
                var data = db.Categories;
                foreach (var item in data)
                {
                    Console.WriteLine(item.CategoryId + " " + item.CategoryName);
                }
                Console.WriteLine();

                var history = db.CustOrderHist("ALFKI");
                foreach (var item in history)
                {
                    Console.WriteLine("{0, 2} {1}", item.Total, item.ProductName);
                }

                Console.WriteLine();

                OrderDetail orderDetail = db.OrderDetails.First();
                Console.WriteLine(orderDetail.Product.ProductName);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace LINQLab
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double OrderAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>(){
                new Customer { CustomerId = 1, Name = "Amit Shah", City = "Ahmedabad" },
                new Customer { CustomerId = 2, Name = "Priya Patel", City = "Surat" },
                new Customer { CustomerId = 3, Name = "Rahul Mehta", City = "Vadodara" },
                new Customer { CustomerId = 4, Name = "Sneha Desai", City = "Rajkot" },
                new Customer { CustomerId = 5, Name = "Karan Joshi", City = "Ahmedabad" },
                new Customer { CustomerId = 6, Name = "Neha Trivedi", City = "Surat" },
                new Customer { CustomerId = 7, Name = "Vivek Kumar", City = "Mumbai" },
                new Customer { CustomerId = 8, Name = "Anjali Singh", City = "Delhi" },
                new Customer { CustomerId = 9, Name = "Rohan Verma", City = "Pune" },
                new Customer { CustomerId = 10, Name = "Pooja Sharma", City = "Jaipur" },
                new Customer { CustomerId = 11, Name = "Harsh Patel", City = "Ahmedabad" },
                new Customer { CustomerId = 12, Name = "Nisha Gupta", City = "Indore" },
                new Customer { CustomerId = 13, Name = "Arjun Rana", City = "Chandigarh" },
                new Customer { CustomerId = 14, Name = "Meera Iyer", City = "Bengaluru" },
                new Customer { CustomerId = 15, Name = "Sanjay Kulkarni", City = "Nagpur" },
                new Customer { CustomerId = 16, Name = "Ritika Jain", City = "Udaipur" },
                new Customer { CustomerId = 17, Name = "Yash Parmar", City = "Vadodara" },
                new Customer { CustomerId = 18, Name = "Komal Bhatt", City = "Rajkot" },
                new Customer { CustomerId = 19, Name = "Deepak Soni", City = "Surat" },
                new Customer { CustomerId = 20, Name = "Isha Kapoor", City = "Delhi" }
            };

            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 1, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 104, CustomerId = 2, ProductName = "Mobile Phone", Category = "Electronics", OrderAmount = 25000 },
                new Order { OrderId = 106, CustomerId = 3, ProductName = "Office Chair", Category = "Furniture", OrderAmount = 8000 },
                new Order { OrderId = 108, CustomerId = 4, ProductName = "Refrigerator", Category = "Appliances", OrderAmount = 42000 },
                new Order { OrderId = 109, CustomerId = 5, ProductName = "Dining Table", Category = "Furniture", OrderAmount = 18000 },
                new Order { OrderId = 111, CustomerId = 6, ProductName = "Air Conditioner", Category = "Appliances", OrderAmount = 38000 },
                new Order { OrderId = 113, CustomerId = 7, ProductName = "Headphones", Category = "Electronics", OrderAmount = 3500 },
                new Order { OrderId = 114, CustomerId = 8, ProductName = "Bookshelf", Category = "Furniture", OrderAmount = 9500 },
                new Order { OrderId = 115, CustomerId = 9, ProductName = "Microwave Oven", Category = "Appliances", OrderAmount = 12000 },
                new Order { OrderId = 116, CustomerId = 10, ProductName = "Smart Watch", Category = "Electronics", OrderAmount = 15000 },
                new Order { OrderId = 118, CustomerId = 11, ProductName = "Printer", Category = "Electronics", OrderAmount = 9000 },
                new Order { OrderId = 119, CustomerId = 12, ProductName = "Sofa", Category = "Furniture", OrderAmount = 30000 },
                new Order { OrderId = 120, CustomerId = 13, ProductName = "Washing Machine", Category = "Appliances", OrderAmount = 28000 },
                new Order { OrderId = 121, CustomerId = 14, ProductName = "Tablet", Category = "Electronics", OrderAmount = 22000 },
                new Order { OrderId = 122, CustomerId = 15, ProductName = "Coffee Table", Category = "Furniture", OrderAmount = 6000 },
                new Order { OrderId = 123, CustomerId = 16, ProductName = "Mixer Grinder", Category = "Appliances", OrderAmount = 4500 },
                new Order { OrderId = 124, CustomerId = 17, ProductName = "Gaming Keyboard", Category = "Electronics", OrderAmount = 5000 },
                new Order { OrderId = 125, CustomerId = 18, ProductName = "Wardrobe", Category = "Furniture", OrderAmount = 27000 },
                new Order { OrderId = 126, CustomerId = 20, ProductName = "Vacuum Cleaner", Category = "Appliances", OrderAmount = 14000 }

            };

            // ==========================================================
            // Write LINQ queries below
            // ==========================================================

            // Query 1:
            // Display the names of all customers along with the products they have ordered.
            // (Use Join)
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Query 1: Display the names of all customers along with the products they have ordered.");
            Console.WriteLine("========================================================================================");
            var result = customers.Join(orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, o) =>
                new {
                    c.Name,
                    o.ProductName
                });

            foreach (var r in result)
            {
                Console.WriteLine(r.ToString());
            }


            // Query 2:
            // Display the details of the first order whose amount is greater than ₹20,000.
            // (Use First() or FirstOrDefault())
            var firstOrder = orders.FirstOrDefault(o => o.OrderAmount > 20000);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("Query 2: Display the details of the first order whose amount is greater than Rs.20,000.");
            Console.WriteLine("========================================================================================");
            if (firstOrder != null)
            {
                Console.WriteLine($"Order ID: {firstOrder.OrderId},\nCustomer ID: {firstOrder.CustomerId}, \n" +
                    $"Product Name: {firstOrder.ProductName}, \nCategory: {firstOrder.Category}, \n" +
                    $"Order Amount: {firstOrder.OrderAmount}");
            }


            // Query 3:
            // Display all customers from Ahmedabad along with the total amount they have spent on orders.
            // (Use Join, Where, GroupBy, and Sum)
            var ahmedabadCustomers = customers.Where(c => c.City == "Ahmedabad")
                .Join(orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, o) =>
                new
                {
                    c.Name,
                    o.OrderAmount
                })
                .GroupBy(x => x.Name)
                .Select(g => new
                {
                    CustomerName = g.Key,
                    TotalAmountSpent = g.Sum(x => x.OrderAmount)
                });
            Console.WriteLine("======================================================================================================");
            Console.WriteLine("Query 3: Display all customers from Ahmedabad along with the total amount they have spent on orders.");
            Console.WriteLine("======================================================================================================");
            foreach (var customer in ahmedabadCustomers)
            {
                Console.WriteLine($"{customer.CustomerName}: {customer.TotalAmountSpent}");
            }


            // Query 4:
            // Display the customer who has placed the highest-value order,
            // along with the product name and order amount.
            // (Use Join and OrderByDescending())
            var highestValueOrder = from c in customers
                                    join o in orders on c.CustomerId equals o.CustomerId
                                    orderby o.OrderAmount descending
                                    select new { Order = o, Customer = c };
            Console.WriteLine("=====================================================================================================================");
            Console.WriteLine("Query 4: Display the customer who has placed the highest-value order, along with the product name and order amount.");
            Console.WriteLine("=====================================================================================================================");
            foreach (var item in highestValueOrder.Take(1))
            {
                Console.WriteLine($"Customer Name: {item.Customer.Name}, Product Name: {item.Order.ProductName}, Order Amount: {item.Order.OrderAmount}");
            }

            Console.ReadKey();
        }
    }
}

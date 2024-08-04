using ConsoleApp1.Model;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Customers> Customers = new List<Customers>()
          {
                new Customers { Id = 1, Name = "Ahmad", Email = "ahmad@example.com", Phone = "123456789", City = "Nablus" },
                new Customers { Id = 2, Name = "Sara", Email = "sara@example.com", Phone = "987654321", City = "Jerusalem" },
                new Customers { Id = 3, Name = "Ali", Email = "ali@example.com", Phone = "555444333", City = "Ramallah" },
                new Customers { Id = 4, Name = "Laila", Email = "laila@example.com", Phone = "444555666", City = "Qalqilia" },
                new Customers { Id = 5, Name = "Omar", Email = "omar@example.com", Phone = "111222333", City = "Hebron" },
                new Customers { Id = 6, Name = "Khaled", Email = "khaled@example.com", Phone = "222333444", City = "Jenin" },
                new Customers { Id = 7, Name = "Nour", Email = "nour@example.com", Phone = "333444555", City = "Bethlehem" },
                new Customers { Id = 8, Name = "Mohammed", Email = "moha@example.com", Phone = "545215214", City = "Nablus" },

            };

          List<Product> Products = new List<Product>()
          {
                new Product { Id = 1, ProductName = "Laptop", Category = "Electronics", Price = 999.99m, Stock = 10 },
                new Product { Id = 2, ProductName = "Smartphone", Category = "Electronics", Price = 699.99m, Stock = 20 },
                new Product { Id = 3, ProductName = "Table", Category = "Furniture", Price = 199.99m, Stock = 15 },
                new Product { Id = 4, ProductName = "Chair", Category = "Furniture", Price = 89.99m, Stock = 25 },
                new Product { Id = 5, ProductName = "Notebook", Category = "Stationery", Price = 2.99m, Stock = 100 },
                new Product { Id = 6, ProductName = "Pen", Category = "Stationery", Price = 0.99m, Stock = 200 }
          };

            Console.WriteLine("The Customer lives in Nablus");

            var NablusCustomer = Customers.Where(Customer => Customer.City == "Nablus");

            foreach (var customer in NablusCustomer)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("Name of all Customers");
            var CustomerName = Customers.Select(cusromer => cusromer.Name);
            foreach (var customer in CustomerName) { Console.WriteLine(customer); }

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("Orderd Name of all Customers");
            var CustomerNameOrder = Customers.OrderBy(o => o.Name);
            foreach (var customer in CustomerNameOrder) {  Console.WriteLine(customer.Name); }

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("First Customers");
            var FirstCustomer = Customers.Select(cusromer => cusromer.Name).Take(1);
            foreach (var customer in FirstCustomer) { Console.WriteLine(customer); }

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("Customer id 1");
            var CustomerId = Customers.Where(c => c.Id == 1);
            foreach (var customer in CustomerId) {  Console.WriteLine(customer); }
            Console.WriteLine("Another way");
            var CustomerId2 = Customers.OrderBy(c => c.Id).Take(1);
            foreach (var customer in CustomerId2) { Console.WriteLine(customer); }

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("Sum Price");
            var SumPrice = Products.Select(p => p.Price).Sum();
            Console.WriteLine(SumPrice.ToString());

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("verify if customers lives in Qalqilia");
            var livesCusomers = Customers.Any(c => c.City == "Qalqilia");
            Console.WriteLine(livesCusomers);

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("Group Customers --- City");
            var groupCustomer = Customers.GroupBy(c => c.City);
            foreach(var  customer in groupCustomer)
            {
                Console.WriteLine(customer.Key);
                foreach(var group in customer)
                {
                    Console.WriteLine(group.Name);
                }
            }

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("First three Customers");
            var threeCustomers = Customers.Select(cusromer => cusromer.Name).Take(3);
            foreach (var customer in threeCustomers) { Console.WriteLine(customer); }
        }

    }
    }


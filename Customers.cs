using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

          public List<Product> PurchasedProducts { get; set; }

        public override string ToString() => $"Id = {Id} Name = {Name} " +
            $"Email = {Email}  Phone = {Phone} City = {City}";

    }
}

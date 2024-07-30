using cSharpReview._10___Order.Entities;
using cSharpReview._10___Order.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpReview._10___Order
{
    internal class Program
    {
        public static void Main1(string[] args)
        {
            
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime dataDeNascimento = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, dataDeNascimento);
            //Console.WriteLine(dataDeNascimento.ToString("dd/MM/yyyy"));

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            
            OrderStatus orderStatus = OrderStatus.Processing;
            Console.WriteLine("Processing");

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Order order = new Order(DateTime.Now, orderStatus, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product Name: ");
                string pname = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(pname, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}

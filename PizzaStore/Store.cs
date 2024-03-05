using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Store
    {
        public void start() 
        {
            Customer c1 = new Customer("Jason ", 12345678);
            Pizza p1 = new Pizza("50A ", 100, "Tomato, Cheese, Minced, Kebab, Pepperoni & Bernaise");
            Order o1 = new Order();
            Console.WriteLine(c1.ToString()+ "\n"+p1.ToString()+"\n"+o1.ToString());
            CalculateTotalPrice(p1.Price);
            Console.WriteLine();

            Customer c2 = new Customer("Svend ", 87654321);
            Pizza p2 = new Pizza("Magarita ", 105, "Tomato & Cheese");
            Order o2 = new Order();
            Console.WriteLine(c2.ToString() + "\n" + p2.ToString() + "\n" + o2.ToString());
            CalculateTotalPrice(p2.Price);
            Console.WriteLine();

            Customer c3 = new Customer("Daniel ", 11223344);
            Pizza p3 = new Pizza("Hawaii ", 110, "Tomato, Cheese & Pineapple");
            Order o3 = new Order();
            Console.WriteLine(c3.ToString() + "\n" + p3.ToString() + "\n" + o3.ToString());
            CalculateTotalPrice(p3.Price);





            Console.ReadKey();
        }
        public void CalculateTotalPrice(int Price)
        {
            double total= Price * 1.25 + 40;
            Console.WriteLine("Total Price: " + total.ToString());
        }

    }
}

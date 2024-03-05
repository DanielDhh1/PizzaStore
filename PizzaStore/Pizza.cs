using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        public string _name;
        public int _price;
        public string _toppings;

        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }
        public string Toppings { get => _toppings; set => _toppings = value; }
    
        public Pizza(string name, int price, string toppings) 
        {
            _name = name;
            _price = price;
            _toppings = toppings;
        }
        public override string ToString()
        {
            return "Pizza: " + Name + ": toppings: " + Toppings + "\nPrice: " + Price + " Dkk";
        }



    }
}

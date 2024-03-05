using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Customer
    { 
            public string _name;
            public int _phonenumber;
            
            public string Name { get => _name; set => _name = value; }
            public int Phonenumber { get => _phonenumber; set => _phonenumber = value; }

             public Customer(string name, int phone)
             {
                _name = name;
                _phonenumber = phone;
             }

             public override string ToString()
             {
                 return "Customer: " + Name + "\nPhonenumber: " + Phonenumber;
             }


}

}


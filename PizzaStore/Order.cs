using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Order
    {
        private int _id;
        private DateTime _date;
        private static int idcounter = 1;


        public int Id { get => _id; private set => _id = value; }
        public DateTime Date { get => _date; private set => _date = value; }
        public Order()
        {
            Id = idcounter;
            Date = DateTime.Now;
            idcounter++;
        }
        public override string ToString()
        {
            return "Order-Id: " + Id + ": Dato: " + Date.ToString("dd:mm:yy kl HH:mm:ss:fff");
        }
    }
}

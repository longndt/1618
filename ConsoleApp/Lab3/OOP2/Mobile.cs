using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //declare OOP class
    internal class Mobile
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Mobile() { }

        public Mobile (string n, double p, int q)
        {
            Name = n;
            Price = p;
            Quantity = q;
        }

        public void PrintMobile()
        {
            Console.WriteLine(Name);
            Console.WriteLine("$" + Price);
            Console.WriteLine(Quantity);
            Console.WriteLine("--------------------");
        }
    }
}

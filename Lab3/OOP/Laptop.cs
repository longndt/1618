using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OOP: Object Oriented Programming
namespace OOP
{
    //Laptop: OOP Class
    internal class Laptop
    {
        //variables (attributes)
        private string Name;
        private string Brand;
        public double Price;
        private int Quantity;
        private bool BestSeller;

        //methods (behaviors)
        //empty (parameterless) constructor  
        public Laptop() { }

        //parameterized constructor 
        public Laptop (string Name, string Brand, double Price, int Quantity, bool BestSeller)
        {
            this.Name = Name;
            this.Brand = Brand;
            this.Price = Price;
            this.Quantity = Quantity;
            this.BestSeller = BestSeller;   
        }

        //getter (observer) : read-only
        public string getName()
        {
            return Name;
        }
        public string displayBrand()
        {
            return this.Brand;
        }

        //setter (mutator) : write
        public void setName (string Name)
        {
            this.Name = Name;
        }

        public void pushBrand (string LaptopBrand)
        {
            Brand = LaptopBrand;
        }

        //custom method
        public void displayLaptopInfo()
        {
            Console.WriteLine("Laptop Name: " + Name);
            Console.WriteLine("Laptop Brand: " + Brand);
            Console.WriteLine("Laptop Price: $" + Price);
            Console.WriteLine("Laptop Quantity: " + Quantity);
            if (BestSeller == true)
                Console.WriteLine("This is best-seller laptop");
        }
    }
}

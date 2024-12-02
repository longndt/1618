using OOP;

//declare Laptop1 object using parameterless constructor
Laptop lap1 = new Laptop();
//assign values to attributes in object
lap1.setName("Macbook Pro"); 
lap1.pushBrand("Apple");
lap1.Price = 999.99;

Console.WriteLine(lap1.getName());
Console.WriteLine(lap1.displayBrand());
Console.WriteLine("$" + lap1.Price);


//declare Laptop2 object using parameterized constructor    
Laptop lap2 = new Laptop("XPS 15", "Dell", 1234.56, 20, true);
lap2.displayLaptopInfo();
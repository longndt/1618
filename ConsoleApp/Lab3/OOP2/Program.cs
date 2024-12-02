using OOP2;

//declare OOP objects (class instances)
Mobile m1 = new Mobile
{
    Name = "iPhone 16 Pro Max",
    Price = 1234,
    Quantity = 20
};

Mobile m2 = new Mobile ("Galaxy S22", 999, 15);

//print OOP objects
Console.WriteLine("Mobile 1");
Console.WriteLine(m1.Name);
Console.WriteLine("$" + m1.Price);
Console.WriteLine(m1.Quantity);

Console.WriteLine("--------------------");

Console.WriteLine("Mobile 2");  
m2.PrintMobile();
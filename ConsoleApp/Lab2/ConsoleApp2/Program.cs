//version 2: add "while" loop to repeat program

int choice = 0;  // 0: default value of integer

//repeat program until user select option 3 to exit program
while (choice != 3)
{
    //show program menu
    Console.WriteLine("Calculator Program");
    Console.WriteLine("1. Sum");
    Console.WriteLine("2. Multiply");
    Console.WriteLine("3. Exit program");

    //get user's choice (input)
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    //int choice = int.Parse(Console.ReadLine());

    //process user's choice
    switch (choice)
    {
        case 1:
            Console.Write("Input x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int total = x + y;
            Console.WriteLine("Total: " + total);
            break;
        case 2:
            Console.Write("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int product = a * b;
            Console.WriteLine("Product: " + product);
            break;
        case 3:
            Console.WriteLine("Program exited. Goodbye !");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}



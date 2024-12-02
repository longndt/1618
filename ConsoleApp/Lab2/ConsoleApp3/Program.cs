//version 3: user only need to input numbers one time

int choice = 0;  // 0: default value of integer

//show program menu
Console.WriteLine("Calculator Program");
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

//repeat program until user select option 3 to exit program
while (choice != 3)
{
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
            int total = x + y;
            Console.WriteLine("Total: " + total);
            break;
        case 2:
            int product = x * y;
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



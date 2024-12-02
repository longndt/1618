Console.WriteLine("Student Management Program");

int total = 0, choice = 0;
do
{
    Console.Write("Enter total students (5-10): ");
    total = Convert.ToInt32(Console.ReadLine());
} while (total < 5 || total > 10);

string[] students = new string[total];
double[] grades = new double[total];

while (choice != 3)
{
    Console.WriteLine("1. Input students");
    Console.WriteLine("2. Display students");
    Console.WriteLine("3. Exit program");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            for (int i = 0; i < total; i++)
            {
                Console.Write("Enter name of student " + (i + 1) + " : ");
                students[i] = Console.ReadLine();
                do
                {
                    Console.Write("Enter grade of student " + (i + 1) + " : ");
                    grades[i] = double.Parse(Console.ReadLine());
                } while (grades[i] < 0 || grades[i] > 10);
            }
            break;
        case 2:
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " name : " + students[i]);
                Console.WriteLine("Student " + (i + 1) + " grade : " + grades[i]);
            }
            break;
        case 3:
            Console.WriteLine("Exiting program. Goodbye !");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}

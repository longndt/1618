//do...while : used to validate user's input

double grade = 0;

do
{
    Console.Write("Enter grade (0-10): ");
    grade = double.Parse(Console.ReadLine());
} while (grade < 0 || grade > 10);

Console.WriteLine("Your grade is " + grade);

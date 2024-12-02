//get input from user (keyboard)
Console.Write("Enter your name: "); 
//default input data type : string
string name = Console.ReadLine();
//string concatenation : + (addition symbol)
Console.WriteLine("Hello " + name);
 
Console.Write("Enter your birth year: "); 
//convert string to integer
int birthYear = int.Parse(Console.ReadLine());
//int birthYear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your was born in " + birthYear);
//calculate age based on birth year
int curentYear = DateTime.Now.Year;
int age = curentYear - birthYear;
Console.WriteLine("You are " + age + " year old now");

Console.Write("Enter your grade: ");
//double grade = double.Parse(Console.ReadLine());
double grade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Your grade is " + grade);
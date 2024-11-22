//grade >= 5 : Pass
//grade < 5  : Fail

double grade = 8.5;
if (grade >= 5.0)
{
    Console.WriteLine("Pass");
    Console.WriteLine("Congratulations");
} else {
    Console.WriteLine("Fail");
}

/*
 * Distinction: 9 - 10
 * Merit : 8 - 9
 * Pass : 5 - 8
 * Refer : 0 - 5
 */
double gpa = 12;
if (gpa >= 9 && gpa <= 10)
    Console.WriteLine("Distinction");
else if (gpa >= 8 && gpa < 9)
    Console.WriteLine("Merit");
else if (gpa >= 5 && gpa < 8)
    Console.WriteLine("Pass");
else if (gpa >= 0 && gpa < 5)
    Console.WriteLine("Refer");
else
    Console.WriteLine("Invalid grade");
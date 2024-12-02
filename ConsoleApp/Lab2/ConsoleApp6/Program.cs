//foreach loop

int[] numbers = [10, 20, 30, 40, 50];
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

string[] names = ["tuan", "hung", "phuong", "mai"];
foreach (var x in names)
{
    Console.WriteLine(x);
}
for (int i=0; i<names.Length; i++)
{
    Console.WriteLine("Student " + (i+1) + " : " + names[i]);    
}

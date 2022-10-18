// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("enter first number");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int f = Convert.ToInt32(Console.ReadLine());
int g = Expotent(e,f);
string n = g.ToString();
if (e> 0 && f > 0)
    Console.WriteLine($"number {e} in degree {f} is {g} ");
else if (e> 0 && f < 0)
       Console.WriteLine($"number {e} in degree {f} is {g}");
else 
    Console.WriteLine("Enter a first number bigger than 0");

int Expotent(int c, int d)
{
    int summary = c;
    if (d> 0)
        for (int i = 1; i < d; i++)
        {
            summary*= c;
        }
        else
        {
            summary = 1;
        }
        return summary;
}


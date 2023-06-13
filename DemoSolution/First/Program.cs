// See https://aka.ms/new-console-template for more information
using First;

Console.WriteLine("Welcome to Calculator App");

Console.WriteLine("Please enter first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter second number");
int b = int.Parse(Console.ReadLine());

Calculator c = new Calculator();
c.Add(a, b);

Console.ReadLine();
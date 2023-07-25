// See https://aka.ms/new-console-template for more information
// Задача 10. Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
string userInput1 = Console.ReadLine() ?? "";
int number = int.Parse(userInput1);
int a1 = 0;
int a2 = 0;
a1 = number % 100;
a2 = a1 / 10;
Console.WriteLine($"{number} -> {a2}");
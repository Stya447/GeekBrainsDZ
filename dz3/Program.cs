// See https://aka.ms/new-console-template for more information
// Задача 6. Программа, которая на вход принимает число и выдает, является ли оно четным
Console.WriteLine("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);
if (number1 % 2 == 0)
{
    Console.WriteLine($"Число {number1} является четным");
}
else 
{
    Console.WriteLine($"Число {number1} не является четным");
}

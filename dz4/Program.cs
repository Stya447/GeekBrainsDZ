// See https://aka.ms/new-console-template for more information
// Задача 8. Программа, которая  на вход принимает число, а на выходе показывает все четные числа до введенного числа
Console.WriteLine("Введите число");
string userInput1 = Console.ReadLine() ?? "";
int number = int.Parse(userInput1);
int numbers = 2;
while (numbers <= number)
{
    Console.Write($"{numbers} ");
    numbers = numbers+2;
}

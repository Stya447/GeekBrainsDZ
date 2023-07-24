// See https://aka.ms/new-console-template for more information
// Задача 2. Программа на вход принимает два числаи выдает, какое число больше, а какое меньше
Console.WriteLine("Введите два числа:");
string userInput1 = Console.ReadLine() ?? "";
string userInput2 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);
int max = 0;
int min = 0;
if (number1 == number2)
{
    Console.WriteLine("Вы ввели одинаковые числы, максимального и минимального не обнаружено");
}
else
{
if (number1 > number2)
{
    max = number1;
    min = number2;
}
else 
{
    max = number2;
    min = number1;
}
Console.WriteLine($"max = {max} min = {min}");
}

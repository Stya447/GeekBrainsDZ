// See https://aka.ms/new-console-template for more information
// Задача 4. Программа, которая принимает на вход три числа и выдает максимальое из этих чисел
Console.WriteLine("Введите три числа через enter");
string userInput1 = Console.ReadLine() ?? "";
string userInput2 = Console.ReadLine() ?? "";
string userInput3 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);
int number3 = int.Parse(userInput3);
int max = 0;
if ((number1 == number2) && (number1 == number3))
{
    Console.WriteLine("Вы ввели одинаковые числа, максимальное не обнаружено");
}
else
{
if ((number1 > number2) && (number1 > number3))
{
    max = number1;
}
else 
{
    if ((number2 > number1) && (number2 > number3))
    {
        max = number2;
    }
    else
    {
        max = number3;
    }
}
Console.WriteLine($"max = {max}");
}

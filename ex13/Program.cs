// See https://aka.ms/new-console-template for more information
// Задача 13. Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int number = int.Parse(userInput1);
if (number > 99)
{
    var some = number.ToString();
    Console.WriteLine($"{number} -> {some[2]}");
}
else{
{
    Console.WriteLine($"{number} -> третьей цифры нет");
} }

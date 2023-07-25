// See https://aka.ms/new-console-template for more information
// Задача 15. Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите чичсло от 1 до 7");
string userInput1 = Console.ReadLine() ?? "";
int number = int.Parse(userInput1);
if (number <= 7)
{
    if ((number == 6) || (number == 7))
    {
        Console.WriteLine($"{number} -> является выходным");
    }
    else
    {
        Console.WriteLine($"{number} -> не является выходным");
    }

}
else
{
    Console.WriteLine("Читайте внимательно и введите, пожалуйста, число занаво");
}

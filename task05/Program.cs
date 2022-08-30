using System;

Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = int.Parse(input);

for (int i = -number; i < number; i++)
{
    Console.Write(i + ", ");
}
Console.Write(number);
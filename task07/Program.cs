using System;

Console.WriteLine("Введите трёхзначное число");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number <= 999 && number >= 100)
    Console.WriteLine("Последняя цифра трёхзначного числа " + number + " - " + number % 10);
else
    Console.WriteLine("Ваше число не трёхзначное");

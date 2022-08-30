using System;

Console.WriteLine("Введите первое число");
string input1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine();
int firstNumber = int.Parse(input1);
int secondNumber = int.Parse(input2);
if (firstNumber == secondNumber * secondNumber) Console.WriteLine($"Число {firstNumber} является квадратом {secondNumber}");
else Console.WriteLine($"Число {firstNumber} НЕ является квадратом {secondNumber}");


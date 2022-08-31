using System;

Console.WriteLine("Введите первое число");
var firstNumber = int.Parse(Console.ReadLine()); //ввод первого числа, преобразование в int
Console.WriteLine("Введите второе число");
var secondNumber = int.Parse(Console.ReadLine()); //ввод второго числа, преобразование в int

if (firstNumber > secondNumber)
    System.Console.WriteLine(firstNumber + " > " + secondNumber);
else if (firstNumber < secondNumber)
    System.Console.WriteLine(firstNumber + " < " + secondNumber);
else
    System.Console.WriteLine(firstNumber + " = " + secondNumber);
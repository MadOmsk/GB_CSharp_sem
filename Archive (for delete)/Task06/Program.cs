/*Определение чётности числа*/
using System;

Console.WriteLine("Введите целое число");
var number = int.Parse(Console.ReadLine()); //ввод числа, преобразование в int

/*Считаем остаток от деления на 2 и выводим результат.*/
if (number % 2 == 0) //
    Console.WriteLine($"Число {number} - чётное");
else
    Console.WriteLine($"Число {number} - нечётное");
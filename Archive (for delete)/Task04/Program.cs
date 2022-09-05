/*Нахождение наибольшего числа из трёх*/
using System;

int[] numbers = new int[3];
Console.WriteLine("Введите первое число");
numbers[0] = int.Parse(Console.ReadLine()); //ввод первого числа, преобразование в int
Console.WriteLine("Введите второе число");
numbers[1] = int.Parse(Console.ReadLine()); //ввод второго числа, преобразование в int
Console.WriteLine("Введите третье число");
numbers[2] = int.Parse(Console.ReadLine()); //ввод третьего числа, преобразование в int

int max = numbers[0]; //создаём переменную max, присваиваем ему значение первого числа
for (int i = 1; i < numbers.Length; i++)
    if (max < numbers[i])
        max = numbers[i];
Console.WriteLine($"Наибольшее число {max}");

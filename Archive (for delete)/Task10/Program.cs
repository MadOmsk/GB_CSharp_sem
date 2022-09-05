/*Программа выводит вторую цифру трёхзначного числа*/

System.Console.WriteLine("Введите трёзначное число");
int number = int.Parse(Console.ReadLine());
if (number < 1000 && number > 99)
{
    Console.Write(number + " -> ");

    number = (number / 10) % 10;

    Console.WriteLine(number);
}
else
    System.Console.WriteLine("Вы ввели не трёхзначное число");

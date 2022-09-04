/*Программа сообщает кратно ли введённое число 7 и 23 одновременно*/

int number = ReadLineWithMessage("Введите целое число");

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
    Console.WriteLine($"Число {number} НЕ кратно 7 и 23");


/*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в int*/
int ReadLineWithMessage(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
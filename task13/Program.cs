/*Программа выводит вторую цифру введённого числа или сообщает, что её нет*/

//ПЕРЕДЕЛАТЬ

int number = ReadLineWithMessage("Введите целое число");
if (number > 99)
{
    Console.Write(number + " -> ");
    number = (number / 10) % 10;
    Console.WriteLine(number);
}
else
    Console.WriteLine("У этого числа нет трёх разрядов");


/*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в int*/
int ReadLineWithMessage(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
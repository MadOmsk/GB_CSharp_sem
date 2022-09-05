/*Программа выводит остаток от деления одного числа на другое, либо сообщает, что одно число кратно другому*/

int dividend = ReadLineWithMessage("Введите целое число (делимое)");
int divider = ReadLineWithMessage("Введите целое число (делитель)");

int modulo = dividend % divider; //остаток от деления
if (modulo == 0)
    Console.WriteLine($"{dividend} кратно {divider}");
else
    Console.WriteLine($"Остаток от деления {dividend} на {divider} равен {modulo}");

/*Метод выводит сообщение, читает строку со ввода терминала и преобразовывает её в int*/
int ReadLineWithMessage(string message){
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
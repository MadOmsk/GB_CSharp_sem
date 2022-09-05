/*Программа удаляет вторую цифру случайно сгенерированного трёхзначного числа*/

int number = new Random().Next(100, 1000);
Console.Write(number + " -> ");

/*int digit1 = number / 100;
int digit2 = number % 10;
int result = digit1 * 10 + digit2;*/

number = ( number / 100 ) * 10 + number % 10; //в одну строчку

//Console.WriteLine(result);
Console.WriteLine(number);
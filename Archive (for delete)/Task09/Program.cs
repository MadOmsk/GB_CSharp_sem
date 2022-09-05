int number = new Random().Next(10, 100);
Console.WriteLine(number);
int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit){
    Console.WriteLine(firstDigit);
} else{
    Console.WriteLine(secondDigit);
}

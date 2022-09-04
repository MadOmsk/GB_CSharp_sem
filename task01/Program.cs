int firstNumber = EducationLibrary.ReadLineWithMessage("Введите первое число");
int secondNumber = EducationLibrary.ReadLineWithMessage("Введите второе число");

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine($"Число {firstNumber} является квадратом {secondNumber}");
}
else
    Console.WriteLine($"Число {firstNumber} НЕ является квадратом {secondNumber}");
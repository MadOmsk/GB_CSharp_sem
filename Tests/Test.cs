using EducationLibraries;

test5("12345678999", 1);
test5("1234567899", 1);
test4("12345678999", 1);
test4("1234567899", 1);
System.Console.WriteLine((long)12345678999);

// Проверяет метод Algebra.SetOfNumber на заданном числе
void test1(double a)
{
    Console.WriteLine(a + " is Q = " + Algebra.SetOfNumber(a, Algebra.Sets.Q));
    Console.WriteLine(a + " is Z = " + Algebra.SetOfNumber(a, Algebra.Sets.Z));
    Console.WriteLine(a + " is N = " + Algebra.SetOfNumber(a, Algebra.Sets.N));
}

// Test Softering.
void test2(double a)
{
    Console.WriteLine(a + " - after softering " + Algebra.Softering(a));
}

// Test InputConsoleDouble.
void test3()
{
    double output = EdInput.InputConsoleDouble("1 2 3");
    System.Console.WriteLine(String.Join(" - ", output));
}

// Test StringToDoubles.
void test4(string a, int n)
{
    try
    {
        double[] output = EdInput.StringToDoubles(a, n, ' ');
        System.Console.WriteLine($"{a} -> {String.Join(" ", output)}");
    }
    catch (FormatException e)
    {
        System.Console.WriteLine(e.Message);
    }
    System.Console.WriteLine("____________");

}

// Test StringToIntegers.
void test5(string a, int n)
{
    try
    {
        long[] output = EdInput.StringToIntegers(a, n, ' ', Algebra.Sets.N);
        System.Console.WriteLine($"{a} -> {String.Join(" ", output)}");
    }
    catch (FormatException e)
    {
        System.Console.WriteLine(e.Message);
    }
    catch (ArithmeticException e)
    {
        System.Console.WriteLine(e.Message);
    }
    System.Console.WriteLine("____________");
}

// Test InputConsoleInteger с 4 аргументами.
void test6()
{
    long[] output = EdInput.InputConsoleInteger("4 числа на ввод", 4, ' ', Algebra.Sets.N);
    System.Console.WriteLine(String.Join(" - ", output));
}

// Test InputConsoleInteger на 1 число
void test7()
{
    long output = EdInput.InputConsoleInteger("Введите число", Algebra.Sets.N);
    System.Console.WriteLine(output);
}


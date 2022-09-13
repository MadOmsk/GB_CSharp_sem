using EducationLibraries;

test9(12345678999.0);
test9(12345678998.0);
test9(12345678500.0);
test9(12345679999.0);
test9(737_873);
test9(737_870);
test9(_randomLong());
test9(_randomLong());
test9(_randomLong());


for (int i = 1; i < 16; i++) test10(i, 100_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 16; i++) test10(i, 1_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 16; i++) test10(i, 10_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 16; i++) test10(i, 100_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 16; i++) test10(i, 500_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 16; i++) test10(i, 1_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 16; i++) test10(i, 2_000_000_000);
System.Console.WriteLine("_______________________________________________");
/*for (int i = 1; i < 9; i++) test10(i, 10_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 100_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 1_000_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 10_000_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 100_000_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 1_000_000_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 10_000_000_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 100_000_000_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 1_000_000_000_000_000_000);
System.Console.WriteLine("_______________________________________________");
for (int i = 1; i < 9; i++) test10(i, 9_200_000_000_000_000_000);*/





//System.Console.WriteLine((long)12345678999);

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
    double output = EdInputOutput.InputConsoleDouble("1 2 3");
    System.Console.WriteLine(String.Join(" - ", output));
}

// Test StringToDoubles.
void test4(string a, int n)
{
    try
    {
        double[] output = EdInputOutput.StringToDoubles(a, n, ' ');
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
        int[] output = EdInputOutput.StringToIntegers(a, n, ' ', Algebra.Sets.N);
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
    int[] output = EdInputOutput.InputConsoleInteger("4 числа на ввод", 4, ' ', Algebra.Sets.N);
    System.Console.WriteLine(String.Join(" - ", output));
}

// Test InputConsoleInteger на 1 число
void test7()
{
    long output = EdInputOutput.InputConsoleInteger("Введите число", Algebra.Sets.N);
    System.Console.WriteLine(output);
}

// Test DoubleToInteger.
void test8(double a)
{
    try
    {
        long output = Algebra.DoubleToInteger(a, Algebra.Sets.Z);
        System.Console.WriteLine($"{a} -> {output}");
    }
    catch (ArithmeticException e)
    {
        System.Console.WriteLine(e.Message);
    }
    System.Console.WriteLine("____________");
}

//RoundTest
void test9(double a)
{
    double result = Math.Round(a, 4, MidpointRounding.AwayFromZero);
    //result = Math.Round(result, 14, MidpointRounding.AwayFromZero);
    bool b = false;
    if (result == a) b = true;
    System.Console.WriteLine($"{a} -> {result} -> {b}");
}

double _randomLong()
{
    var rnd = new Random();
    long a = rnd.NextInt64(100_000_000_000);
    return (double)a + .5;
}

void test10(int znak, int limit)
{
    bool globalB = true;
    bool b = false;
    var rnd = new Random();
    double a;
    double result;
    double positive = 0;
    double negative = 0;
    for (int i = 0; i < 1_000_000; i++)
    {
        a = (double)rnd.Next(limit) + .5;
        result = Math.Round(a, znak, MidpointRounding.AwayFromZero);
        if (a == result) b = true;
        if (b != true) globalB = false;
        if (b == true) positive++;
        else negative++;
        b = false;
    }
    System.Console.WriteLine($"{negative / (positive + negative) * 100 :F2}% : (znak - {znak}, limit - {limit})");
}


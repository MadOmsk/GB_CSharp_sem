using EducationLibraries;


test(Math.Pow(Math.Sqrt(2), 2));
test(-0.000000001);


// Проверяет метод Algebra.SetOfNumber на заданном числе
void test(double a)
{
    Console.WriteLine(a + " is R = " + Algebra.SetOfNumber(a, Algebra.Sets.R));
    Console.WriteLine(a + " is Z = " + Algebra.SetOfNumber(a, Algebra.Sets.Z));
    Console.WriteLine(a + " is N = " + Algebra.SetOfNumber(a, Algebra.Sets.N));
}
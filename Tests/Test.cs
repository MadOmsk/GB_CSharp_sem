using EducationLibraries;


test1(Math.Pow(Math.Sqrt(2), 2));
test1(-0.000000001);
test1((3 - Math.Pow(Math.Sqrt(2), 2)));
test1(0);
test1(-1);
test1(1);
test2(-0.9);
test2(1.000000001);
test2(Math.Pow(Math.Sqrt(Math.Pow(Math.Sqrt(2), 2)),2));
test2(3 - Math.Pow(Math.Sqrt(2), 2));

// Проверяет метод Algebra.SetOfNumber на заданном числе
void test1(double a)
{
    Console.WriteLine(a + " is Q = " + Algebra.SetOfNumber(a, Algebra.Sets.Q));
    Console.WriteLine(a + " is Z = " + Algebra.SetOfNumber(a, Algebra.Sets.Z));
    Console.WriteLine(a + " is N = " + Algebra.SetOfNumber(a, Algebra.Sets.N));
}

void test2(double a){
    Console.WriteLine(a + " - after softering " + Algebra.Softering(a));
}

/*Вывод чётных чисел от 1 до N*/
internal class Program
{
    public delegate int[] integerDelegate(int num); //Делегат, работающий с int, выводит int[]

    static void Main(string[] args)
    {

        /*Просит пользователя ввести число*/
        Console.WriteLine("Введите положительное целое число");
        bool status = double.TryParse(Console.ReadLine(), out double inputNumber); //ввод числа, преобразование в int

        int[] evens = checkParsedValue(generateEvenNumbers, status, inputNumber); //проверка числа, применение к нему метода generateEvenNumbers

        Console.Write(string.Join(", ", evens)); //вывод массива

        /*Метод проверяет является ли число целым положительным, преобразовывает его в int и выполняет необходимую операцию с этим числом, имеющую на выходе int[]
        На входе bool и double - результат double.TryParse()*/
        int[] checkParsedValue(integerDelegate integerDelegate1, bool status, double inputNumber)
        {
            /*Проверяет правильно ли спарсилась строка, выводит необходимое сообщение, если не получилось целое положительное число*/
            try
            {
                if (!status) //проверка является ли строка числом
                    throw new FormatException("Вы ввели не число");
                else if ((Math.Abs((double)(int)inputNumber - inputNumber) > Double.Epsilon)) //проверка является или число целым
                    throw new FormatException("Вы ввели дробное число");
                else if ((int)inputNumber <= 0) //проверка, является ли число положительным
                    throw new FormatException("Вы ввели неположительное число");
                else
                {
                    return integerDelegate1((int)inputNumber); //преобразовывает введённое число в целое и выполняет с ним операцию
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return new int[0];
        }

        /*Метод выводит чётные числа в промежутке от 0 до num*/
        int[] generateEvenNumbers(int number)
        {
            /*Генерация массива для вывода*/
            int[] evens = new int[number / 2]; // создаёт массив чётных чисел
            int j = 0; //дополнительный индекс для внесения чисел в массив evens
            for (int i = 1; i <= number; i++) // проходит по циклу от 1 до числа
            {
                if (i % 2 == 0) //проверяет чётность индекса цикла
                {
                    evens[j] = i; //вносит чётное число в массив evens
                    j++;
                }
            }
            return evens;
        }
    }
}
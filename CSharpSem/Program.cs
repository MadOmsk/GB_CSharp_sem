using EducationLibraries;
using System.Reflection;
class Program
{
    /*Делегат для выполнения методов наследников класса Task*/
    private delegate void taskDelegate();

    /*Массив методов Run*/
    static taskDelegate[] taskRun = { Task01.Run, Task02.Run, Task03.Run, Task04.Run, Task05.Run,
                                         Task06.Run, Task07.Run, Task08.Run, Task09.Run, Task10.Run,
                                         Task11.Run, Task12.Run, Task13.Run, Task14.Run, Task15.Run,
                                         Task16.Run };

    static void Main(string[] args)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        List<Type> types = new List<Type>();
        foreach (Type type in assembly.GetTypes())
            if (type.Namespace == "Task")
                types.Add(type);
        /*Переменная для выхода из бесконечного цикла.*/
        bool quitCheck = true;

        /*Бесконечный цикл, можно выйти, если quitCheck становится false, например, при введении Q.*/
        do
        {
            //Console.Clear();
            Console.WriteLine("Введите номер задачи или q для выхода");
            string userInput = Console.ReadLine()!;
            bool isUserInputInt = int.TryParse(userInput, out int numberOfTask);

            /*В случае если переменная isUserInput = true - выполняется выбор задачи.
            Если она false, то обрабатываются текстовое значение введённой строки, например, выход из программы.*/
            switch (isUserInputInt)
            {
                case true:
                    taskRun[numberOfTask - 1].Invoke();
                    break;
                case false:
                    switch (userInput)
                    {
                        case "q":
                        case "Q":
                            quitCheck = false;
                            break;
                        case "help":
                            help();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
            }
        } while (quitCheck);
    }

    private static void extendedRun(taskDelegate runDelegate1)
    {

        //runDelegate1 += runDelegate1.Method;
        Console.WriteLine(runDelegate1.Method.DeclaringType);
        /*Выводит описание задачи.*/
        //Console.WriteLine(runDelegate1.getDescription);
        /*Запускает метод Run задачи*/
        runDelegate1();
        /*Запускает ожидание до нажатия кнопки Space*/
        EducationLibrary.PressSpaceToContinue();
    }

    /*Вывод справки.*/
    private static void help()
    {
        Console.WriteLine("Введите q для выхода");
        Console.WriteLine("Введите номер задачи для выполнения задачи");
    }
}


using EducationLibraries;
class Program
{
    // Делегат для выполнения методов наследников класса Task.
    private delegate void TaskDelegate();

    // Массив методов Run. В данный момент создаётся вручную.
    static TaskDelegate[] taskRuns = { Task01.Run, Task02.Run, Task03.Run, Task04.Run, Task05.Run,
                                    Task06.Run, Task07.Run, Task08.Run, Task09.Run, Task10.Run,
                                    Task11.Run, Task12.Run, Task13.Run, Task14.Run, Task15.Run,
                                    Task16.Run, Task17.Run, Task18.Run, Task19.Run, Task20.Run,
                                    Task21.Run, Task22.Run, Task23.Run, Task24.Run, Task25.Run,
                                    Task26.Run, Task27.Run, Task28.Run, Task29.Run, Task30.Run,
                                    Task31.Run, Task32.Run, Task33.Run, Task34.Run, Task35.Run,
                                    Task36.Run, Task37.Run, Task38.Run, Task39.Run, Task40.Run, 
                                    Task41.Run, Task42.Run, Task43.Run, Task44.Run, Task45.Run,
                                    Task46.Run, Task47.Run, Task48.Run, Task49.Run, Task50.Run,
                                    Task51.Run, Task52.Run, Task53.Run, Task54.Run, Task55.Run,
                                    Task56.Run, Task57.Run, Task58.Run, Task59.Run, Task60.Run,
                                    Task61.Run, Task62.Run, Task63.Run, Task64.Run, Task65.Run,
                                    TaskX01.Run };

    static void Main(string[] args)
    {
        // Переменная для выхода из бесконечного цикла.
        bool quitCheck = true;

        // Бесконечный цикл, можно выйти, если quitCheck становится false, например, при введении Q.
        do
        {

            Console.Clear();
            Console.WriteLine("Введите номер задачи или q для выхода");
            string userInput = Console.ReadLine()!;
            // Проверяет введены цифры или буквы.
            bool isUserInputInt = int.TryParse(userInput, out int numberOfTask);

            // В случае если переменная isUserInput = true - выполняется выбор задачи.
            // Если она false, то обрабатываются текстовое значение введённой строки, например, выход из программы.
            switch (isUserInputInt)
            {
                case true:
                    if (numberOfTask > 0 && numberOfTask <= taskRuns.Length)
                        s_extendedRun(numberOfTask - 1);
                    else
                    {
                        Console.WriteLine("Введите корректный номер задачи");
                        EdInputOutput.PressSpaceToContinue();
                    }
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
                            Console.WriteLine("Введите корректную команду");
                            EdInputOutput.PressSpaceToContinue();
                            break;
                    }
                    break;
                default:
            }
        } while (quitCheck);
    }

    // Расширенный запуск задачи. Дополнительно останавливает Run() до нажатия кнопки Space.
    private static void s_extendedRun(int numberOfTask)
    {
        // Запускает метод Run задачи.
        taskRuns[numberOfTask].Invoke();
        // Запускает ожидание до нажатия кнопки Space.
        EdInputOutput.PressSpaceToContinue();
    }

    // Вывод справки.
    private static void help()
    {
        Console.WriteLine("Введите q для выхода");
        Console.WriteLine("Введите номер задачи для выполнения задачи");
        Console.WriteLine("Используйте десятичный разделитель, установленный системой. Скорее всего у Вас ',', либо '.'");
        EdInputOutput.PressSpaceToContinue();
    }
}

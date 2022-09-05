using EducationLibraries;
class Program
{
    private delegate void runDelegate(); //Делегат для метода Run

    static void Main(string[] args)
    {
        /*Переменная для выхода из бесконечного цикла.*/
        bool quitCheck = true;

        /*Бесконечный цикл, можно выйти, если quitCheck становится false, например, при введении Q.*/
        do
        {
            //Console.Clear();
            Console.WriteLine("Введите номер задачи или q для выхода");
            string userInput = Console.ReadLine()!;
            bool isUserInputInt = int.TryParse(userInput, out int numberOfTask);

            /*Двойной вложенный свич. 
            В случае если переменная isUserInput = true - выполняется выбор задачи.
            Если она false, то обрабатываются текстовое значение введённой строки, например, выход из программы.*/
            switch (isUserInputInt)
            {
                case true:

                    switch (numberOfTask)
                    {
                        case 1:
                            extendedRun(Task01.Run);
                            break;
                        case 2:
                            extendedRun(Task02.Run);
                            break;
                        case 3:
                            extendedRun(Task03.Run);
                            break;
                        case 4:
                            extendedRun(Task04.Run);
                            break;
                        case 5:
                            extendedRun(Task05.Run);
                            break;
                        case 6:
                            extendedRun(Task06.Run);
                            break;
                        case 7:
                            extendedRun(Task07.Run);
                            break;
                        case 8:
                            extendedRun(Task08.Run);
                            break;
                        case 9:
                            extendedRun(Task09.Run);
                            break;
                        case 10:
                            extendedRun(Task10.Run);
                            break;
                        case 11:
                            extendedRun(Task11.Run);
                            break;
                        case 12:
                            extendedRun(Task12.Run);
                            break;
                        case 13:
                            extendedRun(Task13.Run);
                            break;
                        case 14:
                            extendedRun(Task14.Run);
                            break;
                        case 15:
                            extendedRun(Task15.Run);
                            break;
                        case 16:
                            extendedRun(Task16.Run);
                            break;
                        default:
                            break;
                    }
                    break;
                case false:
                    switch (userInput)
                    {
                        case "q":
                        case "Q":
                            quitCheck = false;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
            }

        } while (quitCheck);


    }
    private static void extendedRun(runDelegate runDelegate1)
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
}


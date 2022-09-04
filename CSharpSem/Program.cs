using EducationLibraries;
class Program : IRunnableFromConsole
{
    static void Main(string[] args)
    {
        /*Переменная для выхода из бесконечного цикла.*/
        bool quitCheck = true;

        /*Бесконечный цикл, можно выйти, если quitCheck становится false, например, при введении Q.*/
        do
        {
            Console.Clear();
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
                            Task01.Run();
                            break;
                            case 2:
                            Task02.Run();
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
}


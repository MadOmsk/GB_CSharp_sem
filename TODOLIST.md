1. Разобраться как выводить description автоматически (без добавления его в Run каждой Task)
2. Класс Task, интерфейс IRunnableFromConsole - нужны ли оба? Вообще с наследованием пока не понятно зачем оно в данном случае нужно
3. Попробовать сделать методы Run нестатичные, чтобы можно было наследоваться от общего класса Task
4. Попробовать реализовать автоматическое добавление всех Task.Run в список (или массив)
5. Попробовать сделать, чтобы при окончании выполнения Run пользователь мог нажать Пробел, чтобы выбирать задачу, либо R, чтобы снова выполнить тот же Run.

На данный момент не реализовано:
* Автоматическое добавление всех задач в один массив или коллекцию для вызова их оттуда
* Автоматически выводить описание задачи перед выводом Run() (сейчас нужно добавлять вручную)
* Настройки пользователя (десятичный разделитель, разделитель символов при одновременном вводе)
* Метод Arrays.PrintTwoDemArray - ввести переменную - количество разрядов выводимого элемента
* Метод Arrats.CopyArray - сделать копирование массива любых объектов
* Выбор R или Пробел после выполнения задачи
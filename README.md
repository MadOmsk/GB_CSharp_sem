Класс, содержащий задачу должен:
* Быть имплементирован методом IRunnableFromConsole из библиотеки EducationLibraries, быть наследником класса Task
* Содержать поле description, содержащее описание задачи
* Выводить на консоль в методе Run() первой строкой описание задачи
* Желательно называться Task<NN>.cs, где <NN> - номер задачи

На данный момент не реализовано:
* Автоматическое добавление всех задач в один массив или коллекцию для вызова их оттуда
* Автоматически выводить описание задачи перед выводом Run() (сейчас нужно добавлять вручную)
* Метод, который принимает строку и требуемое множество (тип числа): целое, натуральное, рациональное и т.д.. Выводит соответствующее число, если удалось распарсить. Если не удалось, то кидает нужное исключение. Попробовать его использовать в некоторых задачах.
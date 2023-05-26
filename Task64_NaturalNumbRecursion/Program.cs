// Программа для вывода всех натуральных чисел в промежутки от N до 1 , использующая рекурсию.

Console.Clear();

int userLimit = GetValueFromUser("Введите желаемое значение границы промежутка: ", "Ошибка ввода!Повторите попытку.");

string result = PrintNaturalNumbs(userLimit);

Console.WriteLine();
PrintReport(result);

/////////////////////////////////////////////////////////////////////////////////////////////////

int GetValueFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userValue) && userValue > 0)
            return userValue;
        Console.WriteLine(errorMessage);
    }
}

string PrintNaturalNumbs(int limit)
{
    if (limit == 1)
        return "1";

    return limit + "," + PrintNaturalNumbs(limit - 1);
}

void PrintReport(string res)
{
    Console.WriteLine("Получены натуральные числа в заданном промежутке: " + res);
}
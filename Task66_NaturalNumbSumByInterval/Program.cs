// Программа для поиска суммы натуральных чисел в промежутке от M до N , использующая рекурсию.

Console.Clear();

int firstLimit = GetValueFromUser("Введите первую границу промежутка, M: ", "Ошибка ввода!M не может быть отрицательным или равным 0.");
int secondLimit = GetValueFromUserWithExcept(firstLimit, "Введите вторую границу промежутка, N: ", "Ошибка ввода!N должно быть больше M.");

int result = GetSumByInterval(firstLimit, secondLimit);

Console.WriteLine();
PrintReport(result);

////////////////////////////////////////////////////////////////////////////////

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

int GetValueFromUserWithExcept(int trigger, string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userValue) && userValue > trigger)
            return userValue;
        Console.WriteLine(errorMessage);
    }
}

int GetSumByInterval(int limit1, int limit2)
{
    if (limit1 == limit2)
        return limit1;

    return limit1 + GetSumByInterval(limit1 + 1, limit2);
}

void PrintReport(int res)
{
    Console.WriteLine($"Сумма натуральных чисел в заданном промежутке равна = {res}");
}
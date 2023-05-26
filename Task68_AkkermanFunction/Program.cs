// Программа для вычисления функции Аккермана , использующая рекурсию.

Console.Clear();

Console.WriteLine("Внимание!Из-за свойств функции Аккермана значение числа m не может превышать число 3, а значение числа n не может превышать число 11 для данной программы!!!");
Console.WriteLine();

int firstNumb = GetFirstValueFromUser("Введите первое неотрицательное целое число m для функции Аккермана: ", "Ошибка ввода!Повторите попытку.");
int secondNumb = GetSecondValueFromUser("Введите второе неотрицательное целое число n для функции Аккермана: ", "Ошибка ввода!Повторите попытку.");

int result = GetValueByAkkermanFunct(firstNumb, secondNumb);

Console.WriteLine();
PrintReport(result);

///////////////////////////////////////////////////////////////////////////////////////////////

int GetFirstValueFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userValue) && userValue >= 0 && userValue < 4)
            return userValue;
        Console.WriteLine(errorMessage);
    }
}

int GetSecondValueFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userValue) && userValue >= 0 && userValue < 12)
            return userValue;
        Console.WriteLine(errorMessage);
    }
}

int GetValueByAkkermanFunct(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return GetValueByAkkermanFunct(m - 1, 1);

    return GetValueByAkkermanFunct(m - 1, GetValueByAkkermanFunct(m, n - 1));
}

void PrintReport(int res)
{
    Console.WriteLine("Результатом функции Аккермана с ввёдеными данными стало значение -> " + res);
}
bool IsWeekend(int number)
{
    if (number == 1) return false;
    if (number == 2) return false;
    if (number == 3) return false;
    if (number == 4) return false;
    if (number == 5) return false;
    if (number == 6) return true;
    if (number == 7) return true;

    else throw new Exception("Нет дня с таким числом!");
}

Console.WriteLine("6 -> " + (IsWeekend(6) ? "Да" : "Нет"));
Console.WriteLine("7 -> " + (IsWeekend(7) ? "Да" : "Нет"));
Console.WriteLine("1 -> " + (IsWeekend(1) ? "Да" : "Нет"));
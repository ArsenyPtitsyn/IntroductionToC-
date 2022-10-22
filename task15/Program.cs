bool IsWeekend(int number)
{
    if (number >= 1 && number <= 5) return false;
    if (number == 6 || number == 7) return true;

    else throw new Exception("Нет дня с таким числом!");
}

try
{
    Console.WriteLine("14 -> " + (IsWeekend(14) ? "Да" : "Нет"));
}
catch
{
    Console.WriteLine("Нет дня с таким числом!");
}
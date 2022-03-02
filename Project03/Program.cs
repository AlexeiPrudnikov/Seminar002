Console.WriteLine("=======Задача № 15=======");
string IsWeekend (int dayNumber)
{
    if ((dayNumber == 6) | (dayNumber == 7))
    {
        return dayNumber + " -> да";
    }
    if ((dayNumber >= 1) & (dayNumber <= 5))
    {
        return dayNumber + " -> нет";
    }
    else
    {
        return "Дня недели с таким номером не существует";
    }
}
try
{
    Console.Write("Введите номер дня недели:");
    int dayNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(IsWeekend(dayNumber));


}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
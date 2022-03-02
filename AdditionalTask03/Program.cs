Console.WriteLine("=======Дополнительная задача № 3=======");
double GetIncome(double startMoney, int month)
{
    double money = startMoney;
    for (int i = 0; i < month; i++)
    {
        money *= 1.015;
    }
    return money;
}

try
{
    Console.Write("Введите скрок вклада в месяцах: ");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Размер депозита через " + month + " месяцев составляет " +  GetIncome(1000, month));

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
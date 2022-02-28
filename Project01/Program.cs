Console.WriteLine("=======Задача № 10=======");
int Reverse (int number)
{
    int[] num = new int[3];
    num[0] = number / 100;
    num[1] = (number / 10) % 10;
    num[2] = number % 10;
    return (num[2] * 100 + num[1] * 10 + num[0]);

}
try
{
    Console.Write("Введите трехзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if ((number < 100) | (number > 999))
    {
        Console.WriteLine("Ошибка ввода, число не трехзначное.");
    }
    else
    {
    Console.WriteLine("Перевернутое число равно:" + Reverse(number));        
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
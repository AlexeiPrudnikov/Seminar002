
Console.WriteLine("=======Задача № 13=======");
string Get3Digit (int number)
{
if (Math.Abs(number) < 100)
{
    return "Третьей цифры нет!";
}
else
{
    return number + " -> " + Math.Abs(number).ToString()[2].ToString();
}

}
try
{
    Console.Write("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Get3Digit(number));


}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("=======Дополнительная задача № 4=======");
bool IsValidNumber(int number)
{
    if (number <= 0) return false;
    int[] digits = new int[10];
    string numStr = number.ToString();
    for (int i = 0; i < numStr.Length; i++)
    {
        digits[Convert.ToInt32(numStr[i].ToString())]++;
        if (digits[Convert.ToInt32(numStr[i].ToString())] >= 2) return false;
    }
    return true;
}
string GetInfo(int number)
{
    if (!(IsValidNumber(number))) return "Число не соостветствует условию задачи";
    if (number < 10) return "Число одноразрядное";
    string numStr = number.ToString();
    int minIndex  = 0;
    int maxIndex  = 0;
    int min = Convert.ToInt32(numStr[0].ToString());
    int max = min;
    for (int i = 1; i < numStr.Length; i++)
    {
        if (Convert.ToInt32(numStr[i].ToString()) > max)
        {
            maxIndex = i;
            max = Convert.ToInt32(numStr[0].ToString());
        }
        else
        {
            if (Convert.ToInt32(numStr[i].ToString()) < min)
            {
                minIndex = i;
                min = Convert.ToInt32(numStr[0].ToString());
            }
        }
    }
    if (minIndex < maxIndex)
    {
        return "Левее минимальная цифра";
    }
    else
    {
        return "Левее максимальная цифра";
    }

}
try
{
    Console.Write("Введите натуральное число, все цифры которого разные: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(GetInfo(number));

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
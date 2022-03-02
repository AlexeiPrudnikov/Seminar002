Console.WriteLine("=======Дополнительная задача № 2=======");
string GetAge(DateTime interestDate, DateTime birthday)
{
    TimeSpan period = interestDate - birthday;
    int days = Convert.ToInt32((interestDate - birthday).TotalDays);
    Console.WriteLine(days);
    string result = "";
    DateTime age = new DateTime();
    age.AddDays(days);
    result = "На " + interestDate.ToShortDateString() + " человеку, рожденному " + birthday.ToShortDateString() + " -> " +
             age.Year + " лет ";
    return result;
}
try
{
    DateTime birthday;
    Console.Write("Введите дату рождения:");
    birthday = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine(GetAge(Convert.ToDateTime("01.02.2022"), birthday));
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
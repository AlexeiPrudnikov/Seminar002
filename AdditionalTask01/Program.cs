Console.WriteLine("=======Дополнительная задача № 1=======");
bool IsValidTriangle (uint[] sides)
{
    if (sides.Length != 3) return false;
    if ((sides[0] + sides[1] <= sides[2])|(sides[0] + sides[2] <= sides[1])|(sides[1] + sides[2] <= sides[0])|((sides[0] * sides[1] * sides[2]) == 0))
    {
        return false;
    }
    return true;
}
string GetTypeTriangle(uint[] sides)
{
    if (IsValidTriangle(sides))
    {
        if ((sides[0] == sides[1]) & (sides[1] == sides[2]))
        {
            return "Треугольник является равносторонним";
        }
        else
        {
            if ((sides[0] == sides[1]) | (sides[1] == sides[2]) | (sides[0] == sides[2]))
            {
                return "Треугольник является равнобедренным";
            }
            else
            {
                return "Треугольник является обычным";
            }
        }

    }
    else
    {
        return "Треугольника с заданными сторонами не существует";
    }
}
try
{
    uint[] sides = new uint[3];
    for (int i = 0; i < 3; i++)
    {
        Console.Write("Введите длину " + (i + 1) + "-й стороны треугольника:");
        sides[i] = Convert.ToUInt32(Console.ReadLine());
    }
    Console.WriteLine(GetTypeTriangle(sides));

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
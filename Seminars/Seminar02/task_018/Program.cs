
System.Console.WriteLine("Введите четверть: ");
int square = Convert.ToInt32(Console.ReadLine());

if (square == 1)
{
    System.Console.WriteLine("Х > 0 и Y > 0");
}
else if (square == 2)
{
    System.Console.WriteLine("Х < 0 и Y > 0");
}
else if (square == 3)
{
    System.Console.WriteLine("Х < 0 и Y < 0");
}
else if (square == 4)
{
    System.Console.WriteLine("Х > 0 и Y < 0");
}
else
{
    System.Console.WriteLine("Неправильный ввод");
}

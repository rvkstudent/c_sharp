System.Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

int result = first % second;

if (result > 0)
{
    System.Console.WriteLine($"Остаток деления {result}");
}
else
{
    System.Console.WriteLine("Первое число кратно второму.");
}
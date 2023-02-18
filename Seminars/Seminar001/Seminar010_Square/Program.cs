System.Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first == second*second || second == first*first )
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
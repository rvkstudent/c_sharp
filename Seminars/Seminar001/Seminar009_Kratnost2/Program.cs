System.Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("Ответ: кратно");
}
else
{
     System.Console.WriteLine("Ответ: нет кратно");
}
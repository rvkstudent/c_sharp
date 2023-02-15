System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{

    System.Console.Write("Последняя цифра числа будет: {0}", number % 10);
}
else
{
    System.Console.Write("Неправильное число");
}

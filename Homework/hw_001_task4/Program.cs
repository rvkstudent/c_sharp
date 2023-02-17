// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(System.Console.ReadLine());

if (num1 == num2 && num2 == num3)
{
    System.Console.WriteLine("Все три числа равны (все три - максимальные)");
}
else if ((num1 >= num2) && (num1 >= num3))
{
    if (num1 == num2)
    {
        System.Console.WriteLine("Первое число - максимальное (и равно второму).");
    }
    else if (num1 == num3)
    {
        System.Console.WriteLine("Первое число - максимальное (и равно третьему).");
    }
    else
    {
        System.Console.WriteLine("Первое число - максимальное.");
    }
    
}
else if ((num2 >= num1) && (num2 >= num3))
{
    if (num1 == num2)
    {
        System.Console.WriteLine("Второе число - максимальное (и равно первому).");
    }
    else if (num2 == num3)
    {
        System.Console.WriteLine("Второе число - максимальное (и равно третьему).");
    }
    else
    {
        System.Console.WriteLine("Второе число - максимальное.");
    }
}
else if ((num3 >= num1) && (num3 >= num2))
{
    if (num3 == num2)
    {
        System.Console.WriteLine("Третье число - максимальное (и равно второму).");
    }
    else if (num3 == num1)
    {
        System.Console.WriteLine("Третье число - максимальное (и равно первому).");
    }
    else
    {
        System.Console.WriteLine("Третье число - максимальное.");
    }
}

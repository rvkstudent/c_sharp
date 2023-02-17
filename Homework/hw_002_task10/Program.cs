// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());

if (num1 / 100 > 0)
{
    System.Console.WriteLine($"Средняя цифра равна: {num1 / 10 % 10}");
}
else
{
    System.Console.WriteLine("Вы ввели неправильное число!");
}
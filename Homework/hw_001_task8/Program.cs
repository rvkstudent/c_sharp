// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Четные числа от 1 до {num1}:");
int index = 2;
while (index <= num1)
{
    System.Console.WriteLine($"{index}");
    index = index + 2;
}

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.Write("Введите число N: ");
int number = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
int index = 1; 
while (index <= number)
{
    System.Console.WriteLine(Math.Pow(index,3));
    index = index + 1;
}
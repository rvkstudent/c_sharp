// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


System.Console.WriteLine("Введите числа: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int result = 1;
for (int i = 1; i <= numbers[1]; i++)
{
    result = numbers[0]*result;
}
System.Console.WriteLine(result);

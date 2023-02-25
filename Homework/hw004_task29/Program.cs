// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Random rand = new Random();
int array_lenght = 8;
int[] array  = new int[array_lenght];

for (int i = 0; i <= array_lenght-1; i++)
{
    array[i] = rand.Next(1,20);
}
System.Console.WriteLine($" [{String.Join(",",array)}]");

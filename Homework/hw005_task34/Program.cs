// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenArray(int size, int leftValue, int rightValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftValue, rightValue);
    }
    return array;
}

int getEvenNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    return count;
}

string PrintArray(int [] array)
{
    return String.Join(",", array);
}

int[] generatedArray = GenArray(6, 100, 999);

System.Console.WriteLine($"Исходный массив [{PrintArray(generatedArray)}]. Количество четных чисел = {getEvenNumbers(generatedArray)}");
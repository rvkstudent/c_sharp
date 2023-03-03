// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int getNonEvenElementsSum(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

string PrintArray(int [] array)
{
    return String.Join(",", array);
}

int[] generatedArray = GenArray(6, -100, 99);

System.Console.WriteLine($"Исходный массив [{PrintArray(generatedArray)}]. Сумма элементов, стоящих на нечётных позициях: {getNonEvenElementsSum(generatedArray)}");
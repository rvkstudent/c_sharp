// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GenArray(int size, int leftValue, int rightValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-9, 10);
    }
    return array;
}

int[] replaceNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

var arr = GenArray(4, -4, 4);

System.Console.WriteLine($"[{String.Join(", ", arr)}]");

System.Console.WriteLine($"[{String.Join(", ", replaceNegative(arr))}]");
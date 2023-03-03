// Задача 38: Задайте массив вещественных чисел. 

// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] GetRandomDoubleArray(int size, double minimum, double maximum)
{

    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * (maximum - minimum) + minimum, 2);
    }
    return array;

}

string PrintArray(double[] array)
{
    return String.Join(" ", array);
}

double[] GetExtremumFromArray(double[] array)
{
    double minimum = array[0];
    double maximum = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }

    return new double[] { minimum, maximum };
}

double[] generatedArray = GetRandomDoubleArray(6, 0, 99);
double[] extremums = GetExtremumFromArray(generatedArray);

System.Console.WriteLine($"Исходный массив [{PrintArray(generatedArray)}].\nМинимальное число в массиве: {extremums[0]}. Максимальное {extremums[1]}");
System.Console.WriteLine($"Разница между минимумом и максимумом равна {extremums[1] - extremums[0]}");
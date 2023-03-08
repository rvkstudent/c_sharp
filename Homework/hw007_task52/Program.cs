// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

double[] CalculateColumnsAverage(int[,] array)
{
    double [] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double ColumnAverage = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            ColumnAverage = ColumnAverage + array[j,i];
        }
        result[i] = Math.Round(ColumnAverage/array.GetLength(0), 2);
    }
    return result;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

var newArray = GenerateMatrix(3, 4);
System.Console.WriteLine("Исходная матрица:");
PrintMatrix(newArray);
double [] result = CalculateColumnsAverage(newArray);
System.Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: [{String.Join("; ", result)}]");
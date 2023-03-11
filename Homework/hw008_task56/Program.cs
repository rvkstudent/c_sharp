// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MinSumMatrixRowNumber(int[,] array)
{
   
    int minimumRowNum = 0;
    int sumRow;
    int minimum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
        }
        if (i == 0) minimum = sumRow;
        if (sumRow < minimum)
        {
            minimum = sumRow;
            minimumRowNum = i;
        }
    }
   
    return minimumRowNum;
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

var newArray = GenerateMatrix(4, 4);
System.Console.WriteLine("Исходная матрица:");
PrintMatrix(newArray);
int minRow =  MinSumMatrixRowNumber(newArray);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");

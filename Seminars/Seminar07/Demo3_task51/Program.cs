// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using System;
using System.Diagnostics;

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

int FindSum(int[,] matr)
{
    int max = Math.Min(matr.GetLength(0), matr.GetLength(1));
    int sum = 0;
    for (int i = 0; i < max; i++)
    {
        sum = matr[i, i] + sum;
    }
    return sum;
}

int FindSum2(int[,] matrix)
{
    int number = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        number += matrix[i, i];
    }
    return number;
}


// int m = ReadInt("Введите количетсво строк матрицы: ");
// int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(12000, 12000);
//PrintMatrix(myMatrix);
System.Console.WriteLine($"Сумма диагонали = {FindSum(myMatrix)}");

DateTime start = new DateTime();
DateTime end = new DateTime();

start = DateTime.Now;
FindSum(myMatrix);
end = DateTime.Now;
Console.WriteLine("Elapsed Time is {0} ms", (end - start).TotalMilliseconds);


start = DateTime.Now;
FindSum(myMatrix);
end = DateTime.Now;
Console.WriteLine("Elapsed Time2 is {0} ms", (end - start).TotalMilliseconds);

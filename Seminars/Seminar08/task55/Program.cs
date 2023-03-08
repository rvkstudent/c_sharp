﻿// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

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

int[,] RotateMatrix(int[,] matr)
{
    int[,] newMatrix = new int[matr.GetLength(1), matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            newMatrix[j,i] = matr[i,j];
            
        }
        
    }

    return newMatrix;

}

var matr = GenerateMatrix(5,5);
PrintMatrix(matr);
System.Console.WriteLine("Изменения");
var newMatrix = RotateMatrix(matr);
PrintMatrix(newMatrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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

int GetElement(int[,] array, int m, int n)
{
    if (m >= 0 & n >= 0 & array.GetLength(0) >= m & array.GetLength(1) >= n)
    {
        return array[m, n];
    }
    else
    {
        return -1;
    }
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

System.Console.WriteLine("Введите размерность массива: ");
int[] arraySize = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
var newArray = GenerateMatrix(arraySize[0], arraySize[1]);
System.Console.WriteLine("Введите позицию элемента массива: ");
int[] position = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
System.Console.WriteLine("Исходная матрица:");
PrintMatrix(newArray);
int result = GetElement(newArray, position[0], position[1]);
if(result == -1)
{
    System.Console.WriteLine("Выбранная позиция за пределами массива.");
}
else
{
    System.Console.WriteLine($"Число в позиции [{String.Join(",",position)}] равно {result}");
}
    

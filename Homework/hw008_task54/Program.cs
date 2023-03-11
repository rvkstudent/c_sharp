// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void SortMatrixRows(int[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Boolean swap = true;
        while(swap == true)
        {
            swap = false;
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i,j] < array[i,j+1])
                {
                    int temp = array[i,j+1];
                    array[i,j+1] = array[i,j];
                    array[i,j] = temp;
                    swap = true;
                }
               
            }
        }
        
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

var newArray = GenerateMatrix(3, 4);
System.Console.WriteLine("Исходная матрица:");
PrintMatrix(newArray);
SortMatrixRows(newArray);
System.Console.WriteLine("Измененная матрица:");
PrintMatrix(newArray);
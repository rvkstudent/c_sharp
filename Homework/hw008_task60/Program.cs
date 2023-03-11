// Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] GenerateMatrix(int m, int n, int k)
{
    int[,,] matrix = new int[m, n, k];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int g = 0; g < n; g++)
            {
                matrix[i, j, g] = rand.Next(20, 100);
            }

        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int g = 0; g < matr.GetLength(2); g++)
            {
                System.Console.Write($"{matr[j, g, i]}({j},{g},{i}) ");
            }
            System.Console.WriteLine();
        }

    }
}

var newArray = GenerateMatrix(2, 2, 2);
System.Console.WriteLine("Исходная матрица построчно:");
PrintMatrix(newArray);

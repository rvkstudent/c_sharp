// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GenerateMatrix(int n, int m)
{
    int[,] matrix = new int[m, n];
    int currentRow = 0;
    int currentColumn = 0;
    int startRow = 0;
    int startColumn = 0;
    int steps = n;
    int direction = 1;
    int count = 1;

    while (count <= m * n)
    {
        for (int i = 0; i < steps; i++)
        {

            currentColumn = startColumn + i * direction;
            matrix[currentRow, currentColumn] = count;
            count++;

        }


        startRow = currentRow + direction;
        steps--;

        for (int i = 0; i < steps; i++)
        {

            currentRow = startRow + i * direction;
            matrix[currentRow, currentColumn] = count;
            count++;
        }

        direction = direction * -1;
        startColumn = currentColumn + direction;

    }
    return matrix;
}


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                System.Console.Write("0" + matr[i, j] + " ");
            }
            else
            {
                System.Console.Write(matr[i, j] + " ");
            }

        }
        System.Console.WriteLine();
    }
}

var newArray = GenerateMatrix(5, 5);
System.Console.WriteLine("Исходная матрица построчно:");
PrintMatrix(newArray);

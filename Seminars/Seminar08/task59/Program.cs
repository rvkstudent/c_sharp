// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 9);
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

int[] minElement(int[,] matr)
{
    int[] coords = new int[2];
    int minimum = matr[0, 0];

    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (matr[i, j] < minimum)
            {
                minimum = matr[i, j];
                coords[0] = i;
                coords[1] = j;
            }


        }

    }

    return coords;

}

int[,] ModifyMatrix(int[,] matr, int[] coords)
{
    int[,] matrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int k = 0;
    int n = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i != coords[0])
        {
            for (int j = 0; j < matr.GetLength(0); j++)
            {

                if (j != coords[1])
                {                    
                    matrix[k, n] = matr[i, j];
                    n++;
                }


            }
            k++;
            n=0;
        }

    }
    return matrix;
}

var matr = GenerateMatrix(7, 7);
PrintMatrix(matr);
System.Console.WriteLine("Координаты минимума:");
var coords = minElement(matr);
System.Console.WriteLine($"{String.Join(",", coords)}");
var newMatrix = ModifyMatrix(matr, coords);
PrintMatrix(newMatrix);




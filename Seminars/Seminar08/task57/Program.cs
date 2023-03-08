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
    int[] coords = new int[9];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int minimum = matr[0,0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            
            if (matr[i,j] < minimum){
                minimum = matr[i,j];

            }

            
        }
        
    }

    return headers;

}

var matr = GenerateMatrix(7,7);
PrintMatrix(matr);
System.Console.WriteLine("Изменения");
var array = PivotMatrix(matr);
for (int i = 0; i < array.Length-1; i++)
{
    System.Console.WriteLine($"Число {i} встречается {array[i]} раз");
}



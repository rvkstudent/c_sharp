// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.



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

void ReplaceMatrix(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int temp = matr[0,j];
        matr[0,j] = matr[matr.GetLength(0)-1, j];
        matr[matr.GetLength(0)-1, j] = temp;
    }

}

var matr = GenerateMatrix(5,5);
PrintMatrix(matr);
System.Console.WriteLine("Изменения");
ReplaceMatrix(matr);
PrintMatrix(matr);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Произведением двух матриц будет матрица, элементы которой равны сумме попарных произведений элементов 
// строки первой матрицы на соответствующие элементы столбца второй матрицы: 
// Из этого следует что перемножить между собой можно матрицы в которых количество 
// столбцов первой равно количеству строк второй.



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

int MultiplyArray(int[] array1, int[] array2)
{
    //System.Console.WriteLine($"Массив 1 = {String.Join(";", array1)}, Массив 2 = {String.Join(",", array2)}");
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        result = result + array1[i] * array2[i];
    }

    return result;
}

dynamic MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int result = 0;
        int[] matrix1Row = new int[matrix1.GetLength(1)];
        int[] matrix2Column = new int[matrix2.GetLength(0)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            result = 0;
            // формируем строки первой матрицы
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1Row[j] = matrix1[i, j];
            }

            // формируем столбцы второй матрицы
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                for (int m = 0; m < matrix2.GetLength(0); m++)
                {
                    matrix2Column[m] = matrix2[m, k];
                }

                //перемножаем
                resultMatrix[i, k] = MultiplyArray(matrix1Row, matrix2Column);
                //System.Console.WriteLine($"{result} i = {i}, k = {k}");   
            }

            //System.Console.WriteLine($"{result}");

        }

    }
    else
    {

        return false;
    }


    return resultMatrix;
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

void TestMatrix(int matrix1RowsQty, int matrix1ColumnsQty, int matrix2RowsQty, int matrix2ColumnsQty)
{

    int[,] matr1 = GenerateMatrix(matrix1RowsQty, matrix1ColumnsQty);
    System.Console.WriteLine("Первая матрица:");
    PrintMatrix(matr1);
    int[,] matr2 = GenerateMatrix(matrix2RowsQty, matrix2ColumnsQty);
    System.Console.WriteLine("Вторая матрица:");
    PrintMatrix(matr2);
    var result = MultiplyMatrix(matr1, matr2);
    if (result is Boolean)
    {
        System.Console.WriteLine("Матрицы нельзя перемножить");
    }
    else
    {
        System.Console.WriteLine("Результирующая матрица:");
        PrintMatrix(result);
    }
}

System.Console.WriteLine("\nТест1........");
TestMatrix(2,2,2,2);
System.Console.WriteLine("\nТест2........");
TestMatrix(2,2,3,2);


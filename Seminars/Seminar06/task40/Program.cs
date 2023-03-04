// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int[] getThreeNumbers()
{
    System.Console.WriteLine("Введите три числа: ");
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

bool isTiangle(int[] arr)
{
    if (arr.Length == 3)
    {
        if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[2] + arr[1] > arr[0])
        {
            return true;
        }
        else{
            return false;
        }
    }
    else{
        System.Console.WriteLine("Неправильный ввод");
        return false;
    }
}

void Output(bool result)
{
    if (result == true)
    {
        System.Console.WriteLine("Правило треугольника соблюдается");
    }
    else
    {
        System.Console.WriteLine("Правило треугольника не соблюдается");
    }
}

var arr = getThreeNumbers();
Output(isTiangle(arr));
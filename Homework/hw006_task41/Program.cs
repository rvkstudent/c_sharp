// Урок 6. Одномерные массивы. Продолжение

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetNumbersFromUser()
{
    System.Console.Write("Введите числа через пробел: ");
    return Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
}

string PrintArray(int[] array)
{
    return String.Join(" ", array);
}

int CountPositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

System.Console.WriteLine($"Количество положительных чисел равно {CountPositiveNumbers(GetNumbersFromUser())}");
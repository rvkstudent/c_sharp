// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да


int[] GenArray(int size, int leftValue, int rightValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-9, 10);
    }
    return array;
}

int[] replaceNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

int getNumber()
{
    System.Console.WriteLine("Введите искомое число: ");
    return Convert.ToInt32(System.Console.ReadLine());
}

bool findNumber(int[] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }

    }
    return result;
}

var arr = GenArray(10, -10, 10);

System.Console.WriteLine($"[{String.Join(", ", arr)}]");

int myNum = getNumber();

bool isInarray = findNumber(arr, myNum);

if (isInarray == true)
{
    System.Console.WriteLine($"Число {myNum} есть в массиве.");
}
else{
    System.Console.WriteLine($"Числа {myNum} нет в массиве.");
}



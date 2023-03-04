// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + String.Join(", ", array) + "]");
}

void Reverse(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
        
    }
}

var myArray = GenArray(10, -10, 10);
PrintArray(myArray);
Reverse(myArray);
PrintArray(myArray);
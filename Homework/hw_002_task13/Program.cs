// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.Write("Введите число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
int temp_num = num1 / 100;
System.Console.WriteLine($"{temp_num}");
if (temp_num > 10)
{
    while (temp_num / 10 > 100)
    {
        temp_num = temp_num / 10;       
    }

    System.Console.WriteLine($"Третья цифра в числе: {temp_num % 10}");

}
else if (temp_num > 0)
{
    System.Console.WriteLine($"Третья цифра в числе: {num1 % 10}");
}
else
{
    System.Console.WriteLine("В этом числе нет третьей цифры.");
}
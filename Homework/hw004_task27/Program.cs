// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int summa = 0;
while(number / 10 > 0)
{
    summa = summa + (number % 10);
    number = number / 10;
}
System.Console.WriteLine(summa + number);
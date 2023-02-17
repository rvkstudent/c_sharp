// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.Write("Введите число: ");
int user_number = Convert.ToInt32(System.Console.ReadLine());

if (user_number > 5 && user_number <=7 )
{
    System.Console.WriteLine("Да - этот день является выходным.");
}
else if (user_number > 0 && user_number <=5)
{
    System.Console.WriteLine("Нет - этот день не является выходным.");
}
else
{
    System.Console.WriteLine("Введенное число не соответствует дню недели.");
}
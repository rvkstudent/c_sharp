// Программа принимающая число и выводящая квадрат этого числа

Console.Write("Enter the number: ");

int number = Convert.ToInt32(Console.ReadLine());
number = number*number;
Console.WriteLine("Квадрат числа: {0}", number);

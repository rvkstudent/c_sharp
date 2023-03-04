
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}


int number = ReadInt("Введите число A: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {Sum(number)}");

number = ReadInt("Введите число B: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {Sum(number)}");

number = ReadInt("Введите число C: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {Sum(number)}");
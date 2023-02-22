// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// Вариант с использованием строки и реверса

int Palindrom_str(int number)
{
    string number_str = number.ToString();
    char[] charArray = number_str.ToCharArray();
    if (charArray.Length != 5)
    {
        return -1;
    }
    else
    {
        Array.Reverse(charArray);
        string reverted_number = new string(charArray);
        if (reverted_number == number_str)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

}

// Вариант с использованием строки и массива

int Palindrom_str2(int number)
{
    string number_str = number.ToString();
    char[] charArray = number_str.ToCharArray();
    if (charArray.Length != 5)
    {
        return -1;
    }
    else
    {
        Boolean isPalindrome = true;
        for (int i = 0; i < charArray.Length / 2; i++)
        {
            if (charArray[i] != charArray[charArray.Length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome == true)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

}


// Вариант без использования строки

int Palindrom_div(int number)
{
    if (number / 10000 > 0 & number / 10000 < 10)
    {
        int reverted_number = 0;
        int temp_number = number;
        while (temp_number / 10 > 0)
        {
            reverted_number = reverted_number * 10 + temp_number % 10;
            temp_number = temp_number / 10;
        }
        reverted_number = reverted_number * 10 + temp_number % 10;

        if (reverted_number == number)
        {
            return 1;
        }
        else
        {
            return 2;
        }

    }
    else
    {
        return -1;
    }

}

// Тесты

if (Palindrom_str(14212) == 2)
{
    System.Console.WriteLine(("Test1 = OK"));
}
else
{
    System.Console.WriteLine(("Test1 Fault"));
}
if (Palindrom_str(12821) == 1)
{
    System.Console.WriteLine(("Test2 = OK"));
}
else
{
    System.Console.WriteLine(("Test1 Fault"));
}
if (Palindrom_str(23432) == 1)
{
    System.Console.WriteLine(("Test3 = OK"));
}
else
{
    System.Console.WriteLine(("Test1 Fault"));
}


System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(System.Console.ReadLine());


if (Palindrom_str(number) == 1)
{
    System.Console.WriteLine("Число является палиндромом!");
}
else if (Palindrom_str(number) == 2)
{
    System.Console.WriteLine("Число не является палиндромом!");
}
else
{
    System.Console.WriteLine("Число не пятизначное!");
}


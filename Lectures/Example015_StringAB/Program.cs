// Собрать строку с числами от a до b

void MyString(int a, int b)
{
    string result = "";
    for (int i = a; i <= b; i++)
    {
        result = result + String.Join(result, Convert.ToString(i));

    }
    System.Console.WriteLine(result);

}

string StringRecursion(int a, int b)
{
    if (a < b) return $"{a}" + StringRecursion(a + 1, b);

    else return $"{b}";
}


// Возвести a в натуральную степень n

int Pow2(int a, int n)
{
    if (n == 1) return a;
    else return a*Pow2(a, n-1);

}

System.Console.WriteLine($"{Pow2(2,1)}" ); 
int[] array = new int[12];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
System.Console.WriteLine($"[{String.Join(", ", array)}]");

int SumPositive = 0;
int SumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        SumPositive += array[i];
    }
    else
    {
        SumNegative += array[i];
    }
}

System.Console.WriteLine($"Сумма положительных чисел: {SumPositive}");
System.Console.WriteLine($"Сумма отрицательных чисел: {SumNegative}");
System.Console.Write("Введите число: ");
int num1 = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
int index = 1; 
while (index <= num1)
{
    System.Console.WriteLine(Math.Pow(index,2));
    index = index + 1;
}
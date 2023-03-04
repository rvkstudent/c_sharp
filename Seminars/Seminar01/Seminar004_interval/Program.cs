System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = -number;
while(i <= number)
{
    System.Console.Write("{0};", i);
    i += 1;
}
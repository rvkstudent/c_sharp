int randNumber = new Random().Next(10, 99);
System.Console.WriteLine(randNumber);
int firstNum = randNumber / 10;
int secondNum = randNumber % 10;

if (firstNum > secondNum)
{
    System.Console.WriteLine(firstNum);
}
else
{
    System.Console.WriteLine(secondNum);
}
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int randNumber = new Random().Next(100, 999);
int randNumber = 329;
System.Console.WriteLine(randNumber);

int firstNum = randNumber / 100;
int secondNum = randNumber % 10;

System.Console.WriteLine($"{firstNum}{secondNum}");
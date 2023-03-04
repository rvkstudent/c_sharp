// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }

// for (int i = 0; i < 40; i++)
// {
//     System.Console.WriteLine($"Факториал {i} = {Factorial(i)}");
// }

double Fibo(int n)
{
    if (n == 1 || n ==2) return 1;
    else return Fibo(n-1) + Fibo(n-2);
}

for (int i = 1; i < 41; i++)
{
    System.Console.WriteLine($"Фибоначи {i} = {Fibo(i)}");
}

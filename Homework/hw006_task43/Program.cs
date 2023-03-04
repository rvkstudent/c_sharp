
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetNumbersFromUser()
{    
    return Array.ConvertAll(Console.ReadLine().Split(","), double.Parse);
}

double[] GetIntersectionPoint(double [] coord1, double [] coord2)
{
    double X = (coord2[0] - coord1[0]) / (coord1[1] - coord2[1]);
    System.Console.WriteLine(X);
    return new double []{ X, 
    coord1[1] * X + coord1[0]};
}

System.Console.Write("Введите b1 и k1 через запятую: ");
double [] coord1 = GetNumbersFromUser();

System.Console.Write("Введите b2 и k2 через запятую: ");
double [] coord2 = GetNumbersFromUser();
System.Console.WriteLine($"Точка пересечения прямых: ({String.Join(" ", GetIntersectionPoint(coord1, coord2))})");


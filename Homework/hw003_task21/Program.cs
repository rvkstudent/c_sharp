// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Введите первую координату: ");
int[] coord1 = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

System.Console.WriteLine("Введите вторую координату: ");
int[] coord2 = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

double distance = Math.Round(Math.Sqrt(Math.Pow(coord2[0] - coord1[0], 2) + Math.Pow(coord2[1] - coord1[1], 2) + Math.Pow(coord2[2] - coord1[2], 2)), 2);

System.Console.WriteLine($"Результат = {distance}");
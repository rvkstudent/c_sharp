

System.Console.WriteLine("Введите первую координату: ");
int[] coord1 = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

System.Console.WriteLine("Введите вторую координату: ");
int[] coord2 = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

double distance = Math.Round(Math.Sqrt(Math.Pow(coord2[0] - coord1[0], 2) + Math.Pow(coord2[1] - coord1[1], 2)), 2);

System.Console.WriteLine($"Результат = {distance}");

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int[] coords = new int[2];

System.Console.WriteLine("Введите X: ");
coords[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if (coords[0] > 0 && coords[1] > coords[1])
{
    System.Console.WriteLine("Мы находимся в первой четверти");
}
else if (coords[0] < 0 && y < coords[1])
{
    System.Console.WriteLine("Мы находимся в третьей четверти");
}
else if (coords[0] > 0 && y < coords[1])
{
    System.Console.WriteLine("Мы находимся в четвертой четверти");
}
else if (coords[0] < 0 && y > coords[1])
{
    System.Console.WriteLine("Мы находимся во второй четверти");
}
else
{
    System.Console.WriteLine("Координата на оси.");
}
Console.Write("Enter username:");
string username = Console.ReadLine();

if(username.ToLower() == "Masha")
{
    Console.WriteLine("Hi, Masha");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
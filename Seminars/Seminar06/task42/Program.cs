
// перевод из десятичной в двоичную систему

int getNumber()
{
    System.Console.WriteLine("Введите искомое число: ");
    return Convert.ToInt32(System.Console.ReadLine());
}

void toBinary(int number)
{
   if (number == 0)
   {
    return;
   }
   toBinary(number/2);
   System.Console.Write(number % 2);
}

toBinary(getNumber());
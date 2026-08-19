int resto, mult3 = 0;
for(int i = 1; i <= 300; i++)
{
    resto = i % 3;
    if (resto == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(i);
        mult3++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(i);
    }
}
Console.WriteLine("a quantidade de multiplos de 3 é: " + mult3);
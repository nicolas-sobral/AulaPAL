int num, resto, mult4 = 0;
for(int i = 0; i <= 10; i++)
{
    Console.WriteLine("digite números: ");
    num = int.Parse(Console.ReadLine());
    resto = num % 4;
    if (resto == 0)
    {
        mult4++;
    }
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("a quantidade de multiplos de 4 é " + mult4);
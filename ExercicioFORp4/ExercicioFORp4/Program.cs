int num, par = 0, resto;
for(int i = 0; i <= 15; i++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("digite números ");
    num = int.Parse(Console.ReadLine());
    resto = num % 2;
    if(resto == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(num);
        par++;
    }
}
Console.WriteLine("a quantidade de números pares digitados é " + par);
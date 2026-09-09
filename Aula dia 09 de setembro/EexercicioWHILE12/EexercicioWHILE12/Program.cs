int cont = 1, n, par = 0;
while (cont <= 15)
{
    Console.WriteLine("digite números: ");
    n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        par++;
    }
    cont++;
}
Console.WriteLine("há " + par + " números pares");
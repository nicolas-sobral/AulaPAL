double n, calculo, cont = 1;
while (cont <= 7)
{
    Console.WriteLine("digite números: ");
    n = double.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        calculo = Math.Pow(n, 2);
        Console.WriteLine(calculo);
    }
    else
    {

        calculo = Math.Pow(n, 3);
        Console.WriteLine(calculo);
    }
    cont++;
}
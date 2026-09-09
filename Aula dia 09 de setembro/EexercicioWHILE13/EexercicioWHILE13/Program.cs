int n, mult, cont = 1;
while (cont <= 3)
{
    Console.WriteLine("digite números: ");
    n = int.Parse(Console.ReadLine());
    mult = n * 9;
    Console.WriteLine("este número multiplicado por 9 é "+ mult);
    cont++;
}
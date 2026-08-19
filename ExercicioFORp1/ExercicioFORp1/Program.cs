int num, nump = 0, numn = 0;
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("digite números: ");
    num = int.Parse(Console.ReadLine());
    if (num < 0)
    {
        numn++;
    }
    else
    {
        nump++;
    }
}
Console.WriteLine("a quantidade de números positivos é " + nump + " e de negativos é " + numn);
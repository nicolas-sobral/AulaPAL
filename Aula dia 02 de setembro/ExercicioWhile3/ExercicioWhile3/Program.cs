int num, numenor = 0;
Console.WriteLine("digite um número: ");
num = int.Parse(Console.ReadLine());
while (numenor < num)
{
    Console.WriteLine(numenor * 2);
    numenor++;
}
int cont = 1, num, resto;
Console.WriteLine("digite um número: ");
num = int.Parse(Console.ReadLine());
while (cont <= num)
{
    resto = cont % 2;
    if(resto == 0)
    {
        Console.WriteLine(cont);
    }
    cont++;
}
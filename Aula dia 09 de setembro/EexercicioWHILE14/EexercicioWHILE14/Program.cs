int cont = 100, resto;
while (cont <= 500)
{
    resto = cont % 3;
    if (resto == 0)
    {
        Console.WriteLine(cont);
    }
    cont++;
}
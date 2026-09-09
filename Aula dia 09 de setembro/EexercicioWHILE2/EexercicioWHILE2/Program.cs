int num = 1, resto;
while (num <= 800)
{
    resto = num % 2;
    if (resto == 0)
    {
        Console.WriteLine(num);
    }
    num++;
}
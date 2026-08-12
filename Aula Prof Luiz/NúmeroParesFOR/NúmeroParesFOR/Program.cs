double resto = 0;
for (int i = 0; i <= 100; i++)
{
    resto = i % 2;
    if (resto == 0)
    {
        Console.WriteLine(i);
    }
}
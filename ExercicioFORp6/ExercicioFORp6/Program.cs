int mult = 0, soma = 0, resto;
for (int i = 1; i <= 50; i++)
{
    Console.WriteLine(i);
    resto = i % 3;
    if (resto == 0)
    {
        soma = soma + i;
        mult++;
    }
}
Console.WriteLine("a soma dos multiplos de 3 é " + soma);

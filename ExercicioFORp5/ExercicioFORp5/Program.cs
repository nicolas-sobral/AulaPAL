int sexo, mas = 0;
double alt;
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("digite seu sexo\n 1 - masculino\n 2 - feminino\n");
    sexo = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua altura ");
    alt = double.Parse(Console.ReadLine());
    if (sexo == 1)
    {
        mas++;
    }
    else
    {
        Console.WriteLine("Altura é " + alt);
    }
}
Console.WriteLine("a quantidade de homens é " + mas);
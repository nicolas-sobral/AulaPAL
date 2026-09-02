int num, resto, cont = 0;
while (cont < 20)
{
    Console.WriteLine("digite numeros: ");
    num = int.Parse(Console.ReadLine());
    resto = num % 3;
    if (resto == 0)
    {
        Console.WriteLine(num + " é número de 3");
    }
    cont++;
}
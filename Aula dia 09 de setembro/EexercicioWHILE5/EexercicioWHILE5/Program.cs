int cont = 1, n, soma = 0;
Console.WriteLine("digite um número: ");
n = int.Parse(Console.ReadLine());
while (cont <= n)
{
    soma = soma + n;
    Console.WriteLine(cont);
    cont++;
}
Console.WriteLine("a soma de todos é " + soma);
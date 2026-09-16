int cont = 1, num, soma = 0;
Console.WriteLine("digite um número: ");
num = int.Parse(Console.ReadLine());
while (cont <= num)
{
    soma = soma + cont;
    Console.WriteLine(soma);
    cont++;
}
int num = 0, valornum, soma = 0;
while (num < 5)
{
    Console.WriteLine("digite números: ");
    valornum = int.Parse(Console.ReadLine());
    soma = soma + valornum;
    num++;
}
Console.WriteLine("o resultado da soma de todos os números é " + soma);
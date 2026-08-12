int num, soma;
soma = 0;
for (int i = 0; i <=10; i++)
{
    Console.WriteLine("digite números ");
    num = int.Parse(Console.ReadLine());
    soma = soma + num;
    Console.WriteLine(soma);
}
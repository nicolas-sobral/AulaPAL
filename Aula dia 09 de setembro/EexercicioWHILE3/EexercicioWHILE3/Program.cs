int cont = 10, num, div;
Console.WriteLine("digite um número (maior que 10): ");
num = int.Parse(Console.ReadLine());
while(cont <= num)
{
    div = cont / 3;
    Console.WriteLine(cont);
    Console.WriteLine(div);
    cont++;
}
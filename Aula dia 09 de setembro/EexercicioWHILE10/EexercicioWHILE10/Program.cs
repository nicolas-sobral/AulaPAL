int n, tabuada, cont = 1;
Console.WriteLine("digite um número: ");
n = int.Parse(Console.ReadLine());
while (cont <= 30)
{
    tabuada = n * cont;
    Console.WriteLine(n + " * " + cont + " = " + tabuada);
    cont++;
}
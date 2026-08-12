int num, tabuada;
Console.WriteLine("digite um número: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("tabuada de " + num + ":");
for(int i = 0; i <= 10; i++)
{
    tabuada = num * i;
    Console.WriteLine(tabuada);
}
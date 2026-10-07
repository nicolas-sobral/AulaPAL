string[] produto = new string[5];
double [] preco = new double[5];
int p;
for(int i = 0; i < 5; i++)
{
    p = i + 1;
    Console.WriteLine("digite o nome do " + p + "º produto: ");
    produto[i] = Console.ReadLine();
    Console.WriteLine("e o preço dele: ");
    preco[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("dados do produto:");
for(int i = 0;i < 5; i++)
{
    Console.WriteLine("nome: "+ produto[i]+"\npreço: " + preco[i]);
}
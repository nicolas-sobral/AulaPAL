int[] idade = new int[5];
string[] nome = new string[5];
int p;
for(int i = 0; i < 5; i++)
{
    p = i + 1;
    Console.WriteLine("digite o nome da " + p + "º pessoa");
    nome[i] = Console.ReadLine();
    Console.WriteLine("digite a idade da " + p + "º pessoa");
    idade[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("pessoas com idade maior que 30 anos:");
for (int i = 0; i < 5; i++)
{
    if (idade[i] >= 30)
    {
        Console.WriteLine(nome[i]);
    }
}
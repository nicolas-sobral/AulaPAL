int[] idade = new int[4];
string[] nome = new string[4];
string[] sexo  = new string[4];
int p;
for(int i = 0; i < 4; i++)
{
    p = i + 1;
    Console.WriteLine("digite o nome da " + p + "º pessoa: ");
    nome[i] = Console.ReadLine();
    Console.WriteLine("digite o sexo da " + p + "º pessoa: ");
    sexo[i] = Console.ReadLine();
    Console.WriteLine("digite a idade da " + p + "º pessoa: ");
    idade[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("os dados digitados são:");
for(int i = 0;i < 4; i++)
{
    Console.WriteLine("Nome: " + nome[i] + "\n sexo: " + sexo[i] + "\n idade: " + idade[i]);
}
string[] nome = new string[6];
string[] cargo = new string[6];
int[] idade = new int[6];
int p;
for(int i = 0; i < nome.Length; i++)
{
    p = i + 1;
    Console.WriteLine("digite o nome do " + p + "º funcionário: ");
    nome[i] = Console.ReadLine();
    Console.WriteLine("digite o cargo do " + p + "º funcionário: ");
    cargo[i] = Console.ReadLine();
    Console.WriteLine("digite a idade do " + p + "º funcionário: ");
    idade[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("dados dos funcionários:");
for(int i =0; i < nome.Length; i++)
{
    Console.WriteLine("nome: " + nome[i] + " \ncargo: " + cargo[i] + " \nidade: " + idade[i]);
}
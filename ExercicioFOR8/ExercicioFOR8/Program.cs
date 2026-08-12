int idade, sexo;
string nome;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("digite seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("digite sua idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine("digite seu sexo:\n1-masculino\n2-feminino ");
    sexo = int.Parse(Console.ReadLine());
    if ((sexo == 1) && (idade >= 21))
    {
        Console.WriteLine(nome + " de idade " + idade + " é do genêro masculino");
    }
}
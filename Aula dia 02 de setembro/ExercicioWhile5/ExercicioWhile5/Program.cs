string nom;
int idade, anonasci, anoatual, cont = 0;
while(cont < 4)
{
    Console.WriteLine("digite seu nome: ");
    nom = Console.ReadLine();
    Console.WriteLine("digite o ano de seu nascimento: ");
    anonasci = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o ano atual: ");
    anoatual = int.Parse(Console.ReadLine());
    idade = anoatual - anonasci;
    Console.WriteLine("a idade de "+nom+" é " + idade);
    cont++;
}
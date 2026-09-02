string sexo, nome;
int exame, cont = 0;
while(cont < 15)
{
    Console.WriteLine("digite seu nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("digite seu sexo:\n masculino - M\n feminino - F ");
    sexo = Console.ReadLine();
    if (sexo == "M" || sexo == "m")
    {
        Console.WriteLine("você " + nome + " precisa fazer o exame");
    }
    else if(sexo == "F" ||  sexo == "f")
    {
        Console.WriteLine("você " + nome + " não precisa fazer o exame");
    }
    else
    {
        Console.WriteLine("sexo inválido");
    }
    cont++;
}
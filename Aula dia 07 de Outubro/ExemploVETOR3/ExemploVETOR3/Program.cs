//PARA CRIAR UM VETOR DE STRING
string[] nome = new string[4];
int[] idade = new int[4];

//ARMAZENAR DADOS NO VETOR
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o nome da posição " + i);
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição " + i + "º do vetor");
    idade[i] = int.Parse(Console.ReadLine());
}

//PARA MOSTRAR VALORES VETOR
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome armazenado na posição " + i + "º do vetor = " + nome[i]);
    Console.WriteLine("A idade armazenada na posição " + i + "º do vetor = " + idade[i]);
}
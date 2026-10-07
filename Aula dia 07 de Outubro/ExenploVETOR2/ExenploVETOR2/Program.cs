//PARA CRIAR UM VETOR DE STRING
string[] nome = new string[4];

//ARMAZENAR DADOS NO VETOR
for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine("Digite o nome da posição " + i);
    nome[i] = Console.ReadLine();
}

//PARA MOSTRAR VALORES VETOR
for(int i = 0;i < nome.Length; i++)
{
    Console.WriteLine("O nome armazenado na posição " + i + "º do vetor = " + nome[i]);
}
// CRIAR VETOR DE INTEIROS

int[] vt = new int[7];

//PARA ARMAZENAR DADOS NO VETOR
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("digite o número da posição: " + i +"º");
    vt[i] = int.Parse(Console.ReadLine());
}

//PARA MOSTRAR OS VALORES DO VETOR

for(int i = 0;i < 7; i++)
{
    Console.WriteLine("O valor da posição " + i + "º do vetor é = " + vt[i]);
}
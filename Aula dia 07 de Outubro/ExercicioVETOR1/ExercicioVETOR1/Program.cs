string[] nome = new string[11];
for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine("digite o nome do jogador nº " + i);
    nome[i] = Console.ReadLine();
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("os jogadores são: ");
Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0;i < nome.Length; i++)
{
    Console.WriteLine(nome[i]);
}
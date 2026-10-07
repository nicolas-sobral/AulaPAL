string[] times = new string[7];
int p;
for(int i = 0; i < 7; i++)
{
    p = i + 1;
    Console.WriteLine("digite o nome do " + p + "º time");
    times[i] = Console.ReadLine();
}
Console.WriteLine("nome dos times digitados:");
for (int i = 0; i < 7; i++)
{
    Console.WriteLine(times[i]);
}
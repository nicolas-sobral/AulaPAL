string[] cor = new string[15];
int p;
for(int i  = 0; i < cor.Length; i++)
{
    p = i + 1;
    Console.WriteLine("digite a cor nº " + p);
    cor[i] = Console.ReadLine();
}
Console.WriteLine("as cores digitadas são: ");
for (int i = 0;i < cor.Length; i++)
{
    Console.WriteLine(cor[i]);
}
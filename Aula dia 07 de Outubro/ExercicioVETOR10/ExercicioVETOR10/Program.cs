string[] elem = new string[10];
string[] elemsimbol = new string[10];
int p;
for(int i  = 0; i < elem.Length; i++)
{
    p = i + 1;
    Console.WriteLine("digite o " + p + "º elemento: ");
    elem[i] = Console.ReadLine();
    Console.WriteLine("digite a sigla do " + p + "º elemento: ");
    elemsimbol[i] = Console.ReadLine();
}
Console.WriteLine("os elementos são:");
for(int i = 0;i < 10; i++)
{
    Console.WriteLine(elemsimbol[i] + " = " + elem[i]);
}
int[] num = new int[10];
int p, resto;
for (int i = 0; i < num.Length; i++)
{
    p = i + 1;
    Console.WriteLine("digite o " + p + "º valor");
    num[i] = int.Parse(Console.ReadLine());
}
for(int i = 0; i < num.Length; i++)
{
    resto = num[i] % 2;
    if (resto == 0)
    {
        Console.WriteLine(num[i]);
    }
}
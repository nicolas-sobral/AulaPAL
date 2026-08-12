double num, quad;
for(int i = 0; i <= 5; i++)
{
    Console.WriteLine("digite números: ");
   num = double.Parse(Console.ReadLine());
    quad = Math.Pow(num, 2);
    Console.WriteLine("o quadrado do número é " + quad);
}
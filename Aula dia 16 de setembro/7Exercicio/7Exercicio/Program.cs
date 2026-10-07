double num,quad, cont = 1;
while (cont <= 9)
{
    Console.WriteLine("digite números ");
    num = int.Parse(Console.ReadLine());
    quad = Math.Pow(num, 2);
    Console.WriteLine("o quadrado desse número é " + quad);
    cont++;
}
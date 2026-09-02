int num = 0, numvalor;
while(num < 3)
{
    Console.WriteLine("digite números: ");
    numvalor = int.Parse(Console.ReadLine());
    Console.WriteLine("o dobro desse número é " + numvalor * 6);
    num++;
}
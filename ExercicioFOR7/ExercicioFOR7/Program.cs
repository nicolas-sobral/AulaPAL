int idade, pesmaior;
pesmaior = 0;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("digite sua idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade >= 18)
    {
        pesmaior = pesmaior + 1;
    }

    Console.WriteLine("existem " + pesmaior + " pessoas maiores de idade");
}
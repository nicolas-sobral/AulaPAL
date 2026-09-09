int notaA, notaB, media, cont = 1;
string al;
while (cont <= 5)
{
    Console.WriteLine("digite seu nome: ");
    al = Console.ReadLine();
    Console.WriteLine("digite a sua primeira nota: ");
    notaA = int.Parse(Console.ReadLine());
    Console.WriteLine("digite a sua segunda nota: ");
    notaB = int.Parse(Console.ReadLine());
    media = (notaA + notaB) / 2;
    Console.WriteLine("o aluno " + al + "teve uma média de " + media + " neste bimestre");
    Console.WriteLine("proximo aluno:");
   cont++;
}

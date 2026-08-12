double slb, slm, hrsextras, INSS, insacres, periacres, taxhrextra, noturacres, slbruto, sll;
int ano, mes, peri, insa, adnotur;
string nome, adnoturn, peric, insal;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("digite o valor do salário base: ");
slb = double.Parse(Console.ReadLine());
Console.WriteLine("digite o valor do salario mínimo: ");
slm = double.Parse(Console.ReadLine());
Console.WriteLine("qual o ano referente ao pagamento? ");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("e o mês referente ao pagamento? em números ");
mes = int.Parse(Console.ReadLine());
if (mes < 1 || mes > 12)
{
    Console.WriteLine("erro de digitação");
}
Console.WriteLine("digite a quantidade de horas extras trabalhadas: ");
hrsextras = double.Parse(Console.ReadLine());
Console.WriteLine("há periculosidade?\n 1-sim\n2-não ");
peri = int.Parse(Console.ReadLine());
if (peri < 1 || peri > 2)
{
    Console.WriteLine("erro de digitação, opção inexistente");
}
Console.WriteLine("qual o tipo de insalubridade?\n1-mínimo\n2-médio\n3-máximo\n4-não tem ");
insa = int.Parse(Console.ReadLine());
if(insa < 1 || insa > 4)
{
    Console.WriteLine("erro de digitação, opção inexistente");
}
Console.WriteLine("há um adicional noturno? \n1-sim\n2-não ");
adnotur = int.Parse(Console.ReadLine());
if(adnotur <1 || adnotur > 2)
{
    Console.WriteLine("erro de digitação, opção inexistente");
}
switch (insa)
{
    case 1:
        insacres = (slm * 10) / 100;
        insal = "minímo";
        break;
    case 2:
        insacres = (slm * 20) / 100;
        insal = "médio";
        break;
    case 3:
        insacres = (slm * 20) / 100;
        insal = "máximo";
        break;
    default:
        insacres = 0;
        insal = "não tem";
        break;

}
if(peri == 1)
{
    periacres = (slb * 30) / 100;
    peric = "sim";
}
else
{
    periacres = 0;
    peric = "não";
}
taxhrextra = (slb + insacres + periacres) / 220 * 1.5 * hrsextras;
switch (adnotur)
{
    case 1:
    noturacres = (slb * 20) / 100;
        adnoturn = "sim";
break;
    default:
        noturacres = 0;
        adnoturn = "não";
        break;
}
slbruto = slb + taxhrextra + insacres + periacres + noturacres;
if(slbruto <= 1174.86)
{
    INSS = (slbruto * 8) / 100;
}
else if(slbruto > 1174.86 &&  slbruto <= 1958.10)
{
    INSS = (slbruto * 9) / 100;
}
else if(slbruto >1958.10 && slbruto <= 3916.20)
{
    INSS = (slbruto * 11) / 100;
}
else
{
    INSS = (3916.20 * 11) / 100;
}
sll = slbruto - INSS;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("DADOS INFORMADOS\nNome do Funcionário: " + nome + "\nMês de Referência: " + mes + "\nSalário Base: R$" + slb + "\nSalário Mínimo: R$" + slm + "\nHoras Extras: " + hrsextras + "\nPericulosidade: " + peri + "\nInsalubridade: " + insal + "\nAdicional Noturno:" + adnoturn);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("CÁLCULOS DO FUNCIONÁRIO\nValor da Insalubridade: " +insacres+ "\nValor da Periculosidade: " + periacres+ "\nValor Hora Extra: "+taxhrextra +"\nAdicional Noturno: "+noturacres+"\nSalário Bruto: "+slbruto+"Desconto INSS: "+sll);
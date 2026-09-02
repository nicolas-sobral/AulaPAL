string resp;
int cont = 1, ponto = 0;
while(cont < 30)
{
    Console.WriteLine("digite a resposta da primeira questão:\nA, B, C ou D ");
    resp = Console.ReadLine();
    switch (resp.ToLower())
    {
        case "a":
            ponto++;
            break;
        default:
            break;
    }
    Console.WriteLine("digite a resposta da segunda questão:\nA, B, C ou D ");
    resp = Console.ReadLine();
    switch (resp.ToLower())
    {
        case "c":
            ponto++;
            break;
        default:
            break;
    }
    Console.WriteLine("digite a resposta da segunda questão:\nA, B, C ou D ");
    resp = Console.ReadLine();
    switch (resp.ToLower())
    {
        case "d":
            ponto++;
            break;
        default:
            break;
    }
    cont++;
}
Console.WriteLine("a pontuação total de todos foi de " + ponto);
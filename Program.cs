int votosAna = 0;
int votosBruno = 0;
int votosNulos = 0;
string voto = "";
//bool votacaoAberta = true;


while (voto != "0")
{
    Console.WriteLine("Votação para presidente da Turma 3º ano B!");
    Console.WriteLine("Voto (1 - Ana, 2 - Bruno, 0 - encerrar votação)");
    voto = Console.ReadLine();

    /*switch (voto)
    {
        case "1":votosAna++;break;
        case"2": votosBruno++;break;
        case"0":break;
        default:votosNulos++;break;
    }
    */
    if (voto == "0")
    {
        Console.WriteLine("Votação encerrada!");
        //votacaoAberta = false;
    }
    else if (voto == "1")
    {
        votosAna++;
    }
    else if (voto == "2")
    {
        votosBruno++;
    }
    else
    {
        votosNulos++;
    }
}

Console.WriteLine($"Ana: {votosAna} | Bruno: {votosBruno} | Nulos: {votosNulos}");

if (votosAna > votosBruno)
{
    Console.WriteLine("Ana venceu a eleição!");
    Console.WriteLine("Saudem a nova presidente da turma 3º ano B!");
}
else if (votosBruno > votosAna)
{
    Console.WriteLine("Bruno venceu a eleição!");
    Console.WriteLine("Saudem o novo presidente da turma 3º ano B!");
} else
{
    Console.WriteLine("Empate...");
    Console.WriteLine("Bem vindos à um mundo sem Presidentes");
}
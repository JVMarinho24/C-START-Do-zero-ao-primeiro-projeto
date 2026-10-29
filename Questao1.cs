/*int votosAna = 0;
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
*/

//------------------------- QUESTÃO 2 ---------------------------//

/*
List<string> usuarios = new List<string>{"lia.souza", "noah.lima", "davi.rocha"};
bool sucesso = false;
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Bem vindo ao cadastro da biblioteca da Uniesp!");
    Console.WriteLine("Vamos começar o cadastro");

    while (!sucesso)
    {
        Console.Write("Nome de usuário: ");
        string usuario = (Console.ReadLine()).Trim().ToLower();

        bool jaCadastrado = false;
        foreach (string cadastrado in usuarios)
        {
            if (cadastrado.ToLower() == usuario.ToLower())
            jaCadastrado = true;
        }

        if (usuario.Length <4 || usuario.Length > 12)
            Console.WriteLine("O usuário precisa ter de 4 a 12 caracteres.");
        else if (usuario.Contains(" "))
            Console.WriteLine("O usuario não pode ter espaços.");
        else if (jaCadastrado)
            Console.WriteLine("Este usuário já está cadastrado.");
        else
        {
            usuarios.Add(usuario);
            Console.WriteLine($"Usuário {usuario} criado.");
            Console.WriteLine($"Total de usuários: {usuarios.Count}");
            sucesso = true;
        }   
    }

    Console.WriteLine("Deseja cadastrar outro usuário? (S/N)");
    string resposta = Console.ReadLine().Trim().ToLower();
    if (resposta == "n")
        continuar = false;
    else
        sucesso = false;    
} */

//------------------------- QUESTÃO 3 ---------------------------//

List<string> dias = new List<string> { "Segunda", "Terça", "Quarta", "Quinta", "Sexta" };
List<int> paes = new List<int>();

int dia = 0;
while (dia < dias.Count)
{
    Console.Write($"{dias[dia]} - pães vendidos: ");
    string texto = (Console.ReadLine() ?? "").Trim();

    bool valido = texto != "";
    foreach (char letra in texto)
    {
        if (letra < '0' || letra > '9')
            valido = false;
    }

    if (valido)
    {
        paes.Add(int.Parse(texto));
        dia++;
    }
    else
        Console.WriteLine("Digite só números. Tente novamente.");
}

decimal total =0m;
int posicaoMaior = 0;
for (int i = 0; i < paes.Count; i++)
{
    total = total + paes[i];

    if (paes[i] > paes[posicaoMaior])
    {
        posicaoMaior = i;       
    }
}

Console.
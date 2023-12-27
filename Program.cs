// Screen Sound

// camelCase
string boasVindas = "\nBoas vindas ao Screen Sound!";
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();

// void quando a função não terá return // PascalCase
void ExibirBoasVindas()
{
    // verbatim literal
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(boasVindas);
}

void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar banda");
    Console.WriteLine("Digite 2 para listar bandas");
    Console.WriteLine("Digite 3 para avaliar banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opçao = Console.ReadLine()!;
    int opçaoInt = int.Parse(opçao);

    switch (opçaoInt)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case -1:
            Console.WriteLine("\nObrigado por utilizar o Screen Sound!");
            break;
        default:
            Console.WriteLine("\nOpção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");

    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda, new List<int> {1});

    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
} 

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("Listagem de bandas\n");

    // for (int i = 0; i < bandas.Count; i++){
    //     Console.WriteLine(bandas[i]);
    // }

    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine(banda);
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    Console.WriteLine("Avaliação de bandas\n");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandas.ContainsKey(nomeBanda))
    {
        Console.Write($"\nDigite uma nota de 1 a 5 para a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA banda {nomeBanda} foi avaliada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine("\nBanda não encontrada!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

void MediaBanda()
{
    Console.Clear();
    Console.WriteLine("Média de bandas\n");

    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandas.ContainsKey(nomeBanda))
    {
        List<int> notas = bandas[nomeBanda];
        Console.WriteLine($"\nA média da banda {nomeBanda} é {notas.Average()}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine("\nBanda não encontrada!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

ExibirBoasVindas();
ExibirMenu();



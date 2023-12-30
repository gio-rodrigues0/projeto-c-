class Musica
{
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
public string Descricao =>
    $"O nome da música é {Nome}, do artista {Artista} e dura {Duracao} minutos";

public void FichaTecnica()
{
    Console.WriteLine($"Nome da música: {Nome}");
    Console.WriteLine($"Artista: {Artista}");
    Console.WriteLine($"Duração: {Duracao}");
    if (Disponivel)
    {
        Console.WriteLine("Disponível no seu plano");
    }
    else
    {
        Console.WriteLine("Adquira o plano premium para ter acesso");
    }
    }
}
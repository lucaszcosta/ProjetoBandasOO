using System.Runtime.Intrinsics.Arm;

class Episodio
{
    private List<string> convidados = new ();


    private string ExibirDuracao(int duracao)
    {
        TimeSpan duracaoSpan = TimeSpan.FromMinutes(duracao);
        return duracaoSpan.ToString();
    }
   


    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Duracao { get;  }
    public int Ordem { get;  }
    public string Resumo => $"{Ordem}. {Titulo} ({ExibirDuracao(Duracao)} min)";
    public string Titulo { get; }


    void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

}

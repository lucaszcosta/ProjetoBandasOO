class Episodio
{
    private List<string> convidados = new ();
    public TimeSpan duracaoSpan = new TimeSpan();


    string ExibirDuracao()
    {
        TimeSpan duracaoSpan = TimeSpan.FromSeconds(Duracao);
        return duracaoSpan.ToString();
    }
   


    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get;  }
    public int Ordem { get;  }
    public string Resumo => $"{Ordem}. {Titulo} ({ExibirDuracao} min)";
    public string Titulo { get; }


    void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}

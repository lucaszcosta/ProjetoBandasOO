class Episodio
{
    private List<string> convidados = new ();

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get;  }
    public int Ordem { get;  }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min)";
    public string Titulo { get; }


    void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}

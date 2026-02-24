namespace TemplateMethod;

public class Filme
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int Ano {  get; set; }
    public double Avaliacao { get; set; }

    public Filme(int id, string titulo, int ano, double avaliacao)
    {
        Id = id;
        Titulo = titulo;
        Ano = ano;
        Avaliacao = avaliacao;
    }

    public override string ToString()
    {
        return $"Id - {Id} | Titulo - {Titulo} | Ano - {Ano} | Avaliação - {Avaliacao}.";
    }

    public static List<Filme> ObterFilmes()
    {
        return new List<Filme>
        {
            new Filme(1, "O Poderoso Chefão", 1972, 9.2),
            new Filme(2, "Interestelar", 2014, 8.7),
            new Filme(3, "Clube da Luta", 1999, 8.8),
            new Filme(4, "A Origem", 2010, 8.8),
            new Filme(5, "Cidade de Deus", 2002, 8.6),
            new Filme(6, "Forrest Gump", 1994, 8.8),
            new Filme(7, "Matrix", 1999, 8.7),
            new Filme(8, "Pulp Fiction", 1994, 8.9),
            new Filme(9, "O Senhor dos Anéis: A Sociedade do Anel", 2001, 8.8),
            new Filme(10, "Parasita", 2019, 8.5),
            new Filme(11, "Gladiador", 2000, 8.5),
            new Filme(12, "Whiplash", 2014, 8.5)
        };
    }
}

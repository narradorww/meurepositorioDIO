namespace DIO.Series
    public class Serie : EntidadeBase
{
    //Atributos
    public Serie(Genero genero, string titulo, string descricao, int ano)
    {
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;

    }
    private Genero Genero { get; set; }
    private string Titulo { get; set; }

    private string Descricao { get; set; }

    private int Ano { get; set; }
    public int Genero1 { get => this.Genero; set => this.Genero = value; }

    //Metodos

    public Serie{int id, Genero genero, string titulo, string descricao,  int ano}
    {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
    }

}
}
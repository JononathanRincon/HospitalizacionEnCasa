namespace HospiEnCasa.App.Dominio;
public class HistoriasClinica
{
    public HistoriasClinica(int id, string diagnostico, string entorno, SugerenciaCuidado sugCuidado)
    {
        this.Id = id;
        this.Diagnostico = diagnostico;
        this.Entorno = entorno;
        this.SugCuidado = sugCuidado;

    }
    public int Id { get; set; }
    public string Diagnostico { get; set; }
    public string Entorno { get; set; }
    public SugerenciaCuidado SugCuidado { get; set; }
}


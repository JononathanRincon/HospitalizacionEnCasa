namespace HospiEnCasa.App.Dominio;
public class SugerenciaCuidado
{
    public SugerenciaCuidado(string fechaHora, string description)
    {
        this.FechaHora = fechaHora;
        this.Description = description;
    }
    public string FechaHora { get; set; }
    public string Description { get; set; }



}

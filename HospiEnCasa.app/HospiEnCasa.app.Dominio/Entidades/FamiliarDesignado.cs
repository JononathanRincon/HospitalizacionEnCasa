namespace HospiEnCasa.App.Dominio;
public class FamiliarDesignado : Persona
{
    public FamiliarDesignado(string parentesco, string correo)
    {
        this.Parentesco = parentesco;
        this.correo = correo;
    }
    public string Parentesco { get; set; }
    public string correo { get; set; }




}

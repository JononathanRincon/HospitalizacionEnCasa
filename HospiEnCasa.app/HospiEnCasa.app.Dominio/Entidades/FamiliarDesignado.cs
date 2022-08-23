using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio;
public class FamiliarDesignado :Persona
{
    [MaxLength(60)]
    public string Parentesco { get; set; }
    [MaxLength(60)]
    public string correo { get; set; }




}

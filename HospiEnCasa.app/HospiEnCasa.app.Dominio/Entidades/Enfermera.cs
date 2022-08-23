using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio;
public class Enfermera : Persona
{   [MaxLength(60)]
    public string tarjetaProfesional { get; set; }
    [MaxLength(60)]
    public int HorasLaborales { get; set; }



}



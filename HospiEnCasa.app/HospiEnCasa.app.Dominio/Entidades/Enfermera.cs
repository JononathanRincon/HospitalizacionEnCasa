namespace HospiEnCasa.App.Dominio;
public class Enfermera : Persona
{
    public Enfermera(string tarjetaProfesional, int horasLaborales)
    {
        this.tarjetaProfesional = tarjetaProfesional;
        this.HorasLaborales = horasLaborales;
    }

   
    public string tarjetaProfesional { get; set; }
    public int HorasLaborales { get; set; }



}



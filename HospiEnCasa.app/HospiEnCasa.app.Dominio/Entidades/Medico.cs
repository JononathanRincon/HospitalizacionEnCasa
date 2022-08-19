namespace HospiEnCasa.App.Dominio;
public class Medico :Persona
{
    public Medico(string especialidad, string codigo, string registro_Paciente)
    {
        this.Especialidad = especialidad;
        this.Codigo = codigo;
        this.Registro_Paciente = registro_Paciente;

    }
    public string Especialidad { get; set; }
    public string Codigo { get; set; }
    public string Registro_Paciente { get; set; }




}

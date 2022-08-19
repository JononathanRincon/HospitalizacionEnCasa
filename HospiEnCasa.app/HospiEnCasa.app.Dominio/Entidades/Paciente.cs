
namespace HospiEnCasa.App.Dominio;
public class Paciente :Persona
{
    public Paciente(string direccion, string ciudad, string fechaNacimiento,
                    HistoriasClinica[] historiaClinica)
    {
        this.Direccion = direccion;
        this.Ciudad = ciudad;
        this.FechaNacimiento = fechaNacimiento;
        this.HistoriaClinica = historiaClinica;

    }
    public string Direccion { get; set; }
    public string Ciudad { get; set; }
    public string FechaNacimiento { get; set; }
    public HistoriasClinica[] HistoriaClinica { get; set; }



}

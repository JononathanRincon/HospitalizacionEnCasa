
namespace HospiEnCasa.App.Dominio;
public class Paciente :Persona
{
    [MaxLength(60)]
    public string Direccion { get; set; }
    [MaxLength(60)]
    public string Ciudad { get; set; }

    public DateTime FechaNacimiento { get; set; }
    public ICollection<HistoriasClinica> HistoriaClinica { get; set; }




}

using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio;
public class SugerenciaCuidado
{
    [Key]
    public Guid Id { get; set; }
    public DateTime FechaHora { get; set; }
    [MaxLength(150)]
    public string Description { get; set; }
    public ICollection<HistoriasClinica> HistoriaClinica { get; set; }




}

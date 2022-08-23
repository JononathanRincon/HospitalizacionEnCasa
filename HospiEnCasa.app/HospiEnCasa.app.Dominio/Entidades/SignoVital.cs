using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio;
public class SignoVital
{    
    [Key]
    public Guid Id { get; set; }
    [Required]
    
    public DateTime Fecha_Horario { get; set; }
    [MaxLength(30)]
    public string TipoSigno { get; set; }
    [MaxLength(30)]
    public string Valor { get; set; }
    public ICollection<HistoriasClinica> HistoriaClinica { get; set; }
}

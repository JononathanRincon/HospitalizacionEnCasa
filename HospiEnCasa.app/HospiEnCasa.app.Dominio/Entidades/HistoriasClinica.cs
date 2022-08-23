using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospiEnCasa.App.Dominio;
public class HistoriasClinica
{
    [Key]
    public Guid Id { get; set; }
    [ForeignKey("PacienteId")]
    public Guid PacienteId { get; set; }
    [ForeignKey("SignoVitalId")]
    public Guid SignoVitalId { get; set; }
    [ForeignKey("sugerenciaId")]
    public Guid sugerenciaCuidadoId { get; set; }
    [Required]
    [MaxLength(120)]
    public string Diagnostico { get; set; }
    [Required]
    [MaxLength(100)]
    public string Entorno { get; set; }
    
    public SugerenciaCuidado Sugerencia_cuidado { get; set; }
    public virtual Paciente Paciente { get; set; }
    public virtual SignoVital SignoVitales { get; set; }
}


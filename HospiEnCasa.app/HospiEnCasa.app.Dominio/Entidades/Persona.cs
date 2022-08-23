
using System;
using System.ComponentModel.DataAnnotations;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(60)]
        public string Apellido { get; set; }
        [Required]
        [MaxLength(60)]
        public string NumeroTelefonico { get; set; }
        [Required]
        [MaxLength(60)]
        [Required]
        public EGenero Egenero { get; set;} 

        

    }
}

using System;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroTelefonico { get; set; }
        public EGenero Egenero { get; set;} 
        public Persona(int id, string nombre, string apellido, string numeroTelefonico, EGenero egenero)
        {
            this.Id = id ?? throw new ArgumentNullException(nameof(tarjetaProfesional));
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NumeroTelefonico = numeroTelefonico;
            this.Egenero = egenero;
        }

    }
}
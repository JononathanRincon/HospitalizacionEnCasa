namespace HospiEnCasa.App.Dominio.Entidades
{
    public class SugerenciaCuidado
    {
        public DateTime FechaHora { get; set; }
        public string Description { get; set; }

        public SugerenciaCuidado(DateTime Fecha, string Description)
        {

        }

    }
}
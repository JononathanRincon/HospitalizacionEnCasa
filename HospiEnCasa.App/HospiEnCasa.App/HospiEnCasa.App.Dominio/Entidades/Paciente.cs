namespace HospiEnCasa.App.Dominio.Entidades
{
    
    public class Paciente:Persona
    {
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public HistoriasClinica[] HistoriaClinica { get; set; }
        public Paciente(string Direccion, string Ciudad, datetime FechaNacimiento,
                        HistoriasClinica[] HistoriaClinica)

        {
            
        }
        

    }
}
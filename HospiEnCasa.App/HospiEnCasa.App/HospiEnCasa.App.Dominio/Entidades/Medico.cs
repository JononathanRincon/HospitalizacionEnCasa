namespace HospiEnCasa.App.Dominio
{
    
    public class Medico:Persona
    {
        public string Especialidad { get; set; }
        public string Codigo { get; set; }
        public string Registro_Paciente { get; set; }

        public Medico(string especialidad, string codigo, string registro_paciente )
        {

        }
        

    }
}
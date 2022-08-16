namespace HospiEnCasa.App.Dominio.Entidades
{    
    public class FamiliarDesignado:Persona
    {
        public string Parentesco { get; set; }
        public string correo { get; set; }
        
        public Paciente(string Parentesco, string correo)
        {
            
        }
        

    }
}
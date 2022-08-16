namespace HospiEnCasa.App.Dominio.Entidades
{
    
    public class Enfermera:Persona
    {
        public string tarjetaProfesional { get; set; }
        public int HorasLaborales { get; set; }

        public Enfermera(string tarjetaProfesional, int HorasLaborales){

        }
        public Enfermera(int id,string nombre ,string apellido,
                    Genero genero, string numeroTelefonico, 
                    string tarjetaProfesional, int HorasLaborales) : 
                    base(id, nombre, apellido, genero, numeroTelefonico)
        {

        }

    }
}


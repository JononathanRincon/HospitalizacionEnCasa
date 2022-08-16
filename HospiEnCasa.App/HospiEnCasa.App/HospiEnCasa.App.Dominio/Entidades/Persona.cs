namespace HospiEnCasa.App.Dominio.Entidades
{
    public enum Genero
    {
        Masculino, 
        Femenino
    }

    public class Persona 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroTelefonico { get; set; }
        public Genero Egenero { get; set; }

        public Persona(int id, string nombre, string apellido, Genero genero,
            string numeroTelefonico)
        {

        }

        public Persona()
        {

        }


    }

}

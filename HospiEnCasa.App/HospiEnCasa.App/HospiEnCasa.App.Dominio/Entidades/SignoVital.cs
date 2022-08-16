namespace HospiEnCasa.App.Dominio.Entidades
{
    public class SignoVital
    {
        public int Id { get; set; }
        public Datetime Fecha_Horario { get; set; }
        public string TipoSigno { get; set; }
        public int Valor { get; set; }
    }
}
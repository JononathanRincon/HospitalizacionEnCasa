namespace HospiEnCasa.App.Dominio.Entidades{

    public class HistoriasClinica{
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public SugerenciaCuidado SugCuidado { get; set; }
        public HistoriasClinica(int id, string Diagnostico, string Entorno) {

        }
    }
}
namespace HospiEnCasa.App.Dominio;
public class SignoVital
{
    public SignoVital(int id, string fecha_Horario, string tipoSigno, int valor)
    {
        this.Id = id;
        this.Fecha_Horario = fecha_Horario;
        this.TipoSigno = tipoSigno;
        this.Valor = valor;

    }
    public int Id { get; set; }
    public string Fecha_Horario { get; set; }
    public string TipoSigno { get; set; }
    public int Valor { get; set; }
}

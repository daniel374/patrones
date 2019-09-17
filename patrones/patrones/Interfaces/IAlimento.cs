namespace patrones
{
    public interface IAlimento
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Tipo { get; set; }
    }
}
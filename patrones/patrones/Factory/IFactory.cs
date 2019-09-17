namespace patrones.Factory
{
    public interface IFactory
    {
        IAlimento LeeAlimento(string tipoAlimento);
    }
}
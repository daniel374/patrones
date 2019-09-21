namespace patrones.Factory
{
    /// <summary>
    /// Interfaz fabrica 
    /// Retorna instacia de IAlimento
    /// </summary>
    public interface IFactory
    {
        IAlimento LeeAlimento(string tipoAlimento);
    }
}
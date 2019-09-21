namespace patrones
{
    /// <summary>
    /// Interfaz de alimento
    /// </summary>
    public interface IAlimento
    {
        /// <summary>
        /// Identificador
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Nombre de Alimento
        /// </summary>
        string Nombre { get; set; }
        /// <summary>
        /// Tipo de alimento
        /// </summary>
        string Tipo { get; set; }
    }
}
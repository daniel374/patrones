using System;
using System.Collections.Generic;
using System.Text;

namespace patrones
{
    /// <summary>
    /// Clase Fruta
    /// </summary>
    public class Fruta: IAlimento
    {
        /// <summary>
        /// Id de Fruta
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre Fruta
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// tipo de alimento
        /// </summary>
        public string Tipo { get; set; } = "Fruta";
    }
}

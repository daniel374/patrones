using System;
using System.Collections.Generic;
using System.Text;

namespace patrones
{
    public  class Verdura: IAlimento
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre 
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// tipo 
        /// </summary>
        public string Tipo { get; set; } = "Verdura";
    }
}

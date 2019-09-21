using System;
using System.Collections.Generic;
using System.Text;

namespace patrones.Factory
{
    /// <summary>
    /// Clase fabrica de instancias de alimentos
    /// </summary>
    public class Factory : IFactory
    {

        /// <summary>
        /// Devuelve una intancia de IAlimento de acuerdo
        /// al tipo de alimento recibido como parametro
        /// </summary>
        /// <param name="tipoAlimento"></param>
        /// <returns></returns>
        public IAlimento LeeAlimento(string tipoAlimento)
        {
            switch (tipoAlimento)
            {
                case "verdura":
                    return new Verdura();
                case "fruta":
                    return new Fruta();
                default:
                    return new Fruta();
            }

        }
    }
}

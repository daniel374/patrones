using System;
using System.Collections.Generic;
using System.Text;

namespace patrones.Singleton
{
    /// <summary>
    /// Calse singletosn
    /// </summary>
    public class SingletonAlimentos
    {
        private readonly static List<IAlimento> _instance = new List<IAlimento>()
        {
            new Fruta(){Id=1,Nombre="Manzana" },
            new Fruta(){Id=2,Nombre="Arandano" },
            new Verdura{Id=3, Nombre="Zanahoria"},
            new Verdura{Id=4, Nombre="Espinacas"}
        };
        public SingletonAlimentos() { }

        /// <summary>
        /// Devuelve una unica instancia del tipo
        /// List<IAlimento>
        /// </summary>
        public static List<IAlimento> GetAlimentos
        {
            get
            {
                return _instance;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace patrones.Factory
{
    public class Factory : IFactory
    {
                       
        public IAlimento LeeAlimento(string  tipoAlimento)
        {
            switch(tipoAlimento)
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

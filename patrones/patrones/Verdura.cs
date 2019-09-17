using System;
using System.Collections.Generic;
using System.Text;

namespace patrones
{
    public  class Verdura: IAlimento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } = "Verdura";
    }
}

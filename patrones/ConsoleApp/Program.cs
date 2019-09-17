using patrones.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new Factory();
            Console.WriteLine("Ingrese el tipo de alimento");
            var tipo=Console.ReadLine();
            var alimento=factory.LeeAlimento(tipo);
            Console.WriteLine("Ingrese el nombre del alimento");
            alimento.Nombre= Console.ReadLine();
            Console.WriteLine($" Se instanció el Alimento { alimento.Nombre } de tipo {alimento.Tipo}");
            Console.ReadLine();

        }
    }
}

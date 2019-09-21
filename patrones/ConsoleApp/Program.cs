using patrones.Factory;
using patrones.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// clase principal
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FABRICA");
            IFactory factory = new Factory();
            Console.WriteLine("Ingrese el tipo de alimento (fruta o verdura)");
            var tipo = Console.ReadLine();
            var alimento = factory.LeeAlimento(tipo);
            Console.WriteLine("Ingrese el nombre del alimento");
            alimento.Nombre = Console.ReadLine();
            Console.WriteLine($"Se instanció el Alimento { alimento.Nombre } de tipo {alimento.Tipo}");


            ///Patón Iterator implementado por el framework
            var alimentos = SingletonAlimentos.GetAlimentos;
            Console.WriteLine("SINGLETON E ITERATOR");
            Console.WriteLine("Lista de Alimentos en memoria patron singleton");
            foreach (var item in alimentos)
            {
                Console.WriteLine(item.Nombre);
            }
            Console.ReadLine();

        }
    }
}
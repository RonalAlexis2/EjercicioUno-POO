using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciooUno
{
    internal class Pepita : Persona
    { // se crea metodo para pepita tocar flauta
        public void tocarFlauta(string cancionfaluta)
        {
            Console.WriteLine("pepita toca el tema "+cancionfaluta);
        }
    }
}

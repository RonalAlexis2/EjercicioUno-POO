using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciooUno
{
    internal class Pedro : Persona
    {  //se crea metodo para pedro tocar piano
        public void tocarPiano(string cancionpiano)        
        {
            Console.WriteLine("pedro toca el tema "+cancionpiano);
        }       
    }
}

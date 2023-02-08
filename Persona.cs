using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciooUno
{
    // persona hereda de pedro por extencion y accion persona por implementacion
    internal class Persona:AccionPersona
    {        
        // se sobre escribe los comportamientos         
        public  void caminar()
        {
            Console.WriteLine("Caminando");
        }

        public void gritar()
        {
            Console.WriteLine("gritando");
        }

        public void saltar()
        {
            Console.WriteLine("saltando");
        }

        // se crea variable global de tipo ModeloPersona
         public ModeloPersona variableGlobal;

        // se crea metodo llenar info que recibe datos1 de tipo ModeloPersona y guardamos ese dato1 en la variable global
        public void llenarInfo(ModeloPersona datosPersona)
        {
            variableGlobal = datosPersona;
        }            
    }
}

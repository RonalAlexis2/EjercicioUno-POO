using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciooUno
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            // se instancia pedro             
            Pedro opedro = new Pedro();

            // se crea modelo persona de pedro
            ModeloPersona modelopedro = new ModeloPersona("Blanco",45,"pedro perez");

            //se llena info de pedro
            opedro.llenarInfo(modelopedro);

            // Se llama tocar piano           
            opedro.tocarPiano("la melodia del amor");

            //se llama caminar
            opedro.caminar();

            // se muestra informacion de pedro almacenada
            Console.Write("pedro tiene el pelo de color " + opedro.variableGlobal.getColorPelo(), " su edad es " + opedro.variableGlobal.getEdad(), " y su nombre es " + opedro.variableGlobal.getNombre());
            Console.WriteLine("");
            // se instancia pepita
            Pepita opepita = new Pepita ();

            // se crea modelo persona de pepita
            ModeloPersona modelopepita = new ModeloPersona("Rubio", 25, "pepita perez");

            //se llena info de pepita
            opepita.llenarInfo(modelopepita);

            // se llama caminar en pepita
            opepita.caminar();

            // se llama tocar flauta
            opepita.tocarFlauta("El Titanic");
            Console.ReadKey();
        }
    }
}

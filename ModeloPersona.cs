using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciooUno
{
    internal class ModeloPersona
    {

        // se crean las variables privadas para luego agregar Set y get

        private string colorPelo;
        private int edad;
        private string nombre;


        // se crean Get y Set

        public string ColorPelo { get => colorPelo; set => colorPelo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        // se crea el metodo que va enviar o recibir los datos
        public ModeloPersona(string colorPelo, int edad, string nombre)
        {
           this.ColorPelo = colorPelo;
           this.Edad = edad;
           this.Nombre = nombre;
           
        }
    }
}

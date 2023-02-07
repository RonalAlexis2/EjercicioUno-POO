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
        public String getColorPelo()
        {
            return colorPelo;
        }
        public void setColorPelo(String colorPelo)
        {
            this.colorPelo = colorPelo;
        }

        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public String getNombre()
        {
            return nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        // se crea el metodo que va enviar o recibir los datos
        public ModeloPersona(string colorPelo, int edad, string nombre)
        {
            this.colorPelo = colorPelo;
            this.edad = edad;
            this.nombre = nombre;
        }
    }
}

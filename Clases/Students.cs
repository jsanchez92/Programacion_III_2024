using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClase_POO.Clases
{
    internal class Students : People
    {
        // Ámbito de Atributos
        
        public string Carrera { get; set; }
        public string Grado { get; set; }


        //La Herencia: es literal una clase heredada todas las
        //propiedades, metodos, reglas de la clase principal


        //Polimorfismo: se da cuando una clase tiene la
        //capacidad de tomar la forma de otra

        //Constructores

        public Students()
        {            
        }
        public Students(string carera, string grado)
        {
            this.Carrera = carera;
            this.Grado = grado;
        }

        // Sobreescritura de Metodos

        // Ámbito de Métodos     

        public override void Hablar()
        {

        }


        //Sobreescritura del metodo ToString();
        public override string ToString()
        {

            return $"Hola {this.Nombres} {this.Apellidos} tu carnet es: {this.Carnet} \nBienvenido al Sistema";
        }
    }
}

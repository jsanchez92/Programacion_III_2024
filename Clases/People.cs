using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClase_POO.Clases
{
    public abstract class People
    {
        // Ámbito de Atributos
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Carnet { get; set; }
        public int Id { get; set; }
        public int INS { get; set; }
        public string Dni { get; set; }

        public abstract void Hablar();

        public override string ToString()
        {

            return $"Hola {this.Nombres} {this.Apellidos} \nBienvenido al Sistema.";
        }
    }
}

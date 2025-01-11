using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClase_POO.Controladores
{
    public interface IProyectoX
    {
        public string Nombre { get; set; }
        public string Correr();
        public string Hablar();
    }
}

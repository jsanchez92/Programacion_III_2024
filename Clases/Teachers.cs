using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClase_POO.Clases
{
    internal class Teachers: People
    {
        
        public string Profecion { get; set; }
        public int Salario { get; set; }

        //  Sobreeescritura de Metodo
        public override void Hablar()
        {
            throw new NotImplementedException();
        }

        // Ámbito de Métodos

    }
}

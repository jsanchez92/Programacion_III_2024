using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClase_POO.Controladores
{
    internal interface IBuider
    {
        public string Add();
        public string Edit();
        public string Delete(int Id);
        public string Show(int Id);

    }
}

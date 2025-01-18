using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClase_POO.Controladores
{
    public class CStudents : IBuider
    {
        /// <summary>
        /// Metodo para Agregar un nuevo estudiante
        /// </summary>
        /// <returns></returns>
        public string Add()
        {
            string respuesta = "";
            try
            {
                respuesta = "Ok";
                //throw new Exception("Esto es una excepción de prueba.");
            }
            catch (Exception ex)
            {
                respuesta =ex.Message+"\n\n"+ ex.StackTrace;// MessageBox.Show(ex.Message);
            }
            return respuesta;
        }

        public string Delete(int Id)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
            throw new NotImplementedException();
        }

        public string Edit()
        {
            throw new NotImplementedException();
        }

        public string Show(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

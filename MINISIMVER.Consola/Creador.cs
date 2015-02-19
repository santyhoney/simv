using MINISIMVER.Datos;
using MINISIMVER.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINISIMVER.Consola
{
    public class Creador
    {
        public Creador()
        {
            
        }


        public void CrearEntidad()
        {
            try
            {

                MINISIMVERContexto contexto = new MINISIMVERContexto();
                contexto.Estados.Add(new EntidadFederativa()
                {
                    Nombre = "TABASCO",
                    Clave = "31"
                });
                contexto.SaveChanges();
                Console.WriteLine("Nuevo estado agregado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadKey();
        }

    }
}

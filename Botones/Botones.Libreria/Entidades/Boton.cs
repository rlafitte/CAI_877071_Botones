using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botones.Libreria.Entidades
{
    public class Boton
    {
        int _id;
        string _descripcion;

        public Boton(int id)
        {
            _id = id;
        }

        public Boton(string descripcion)
        {
            _descripcion = descripcion;
        }

        public Boton(int id, string descripcion)
        {
            _id = id;
            _descripcion = descripcion;
        }
    }
}

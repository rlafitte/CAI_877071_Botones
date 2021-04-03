using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botones.Libreria.Entidades
{
    public class Boton
    {
        private int _id;
        private string _descripcion;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }

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

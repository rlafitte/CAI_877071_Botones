using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botones.Libreria.Excepciones;

namespace Botones.Libreria.Entidades
{
    public class Controlador
    {
        int _id;
        List<Boton> _listaBotones;

        public Controlador()
        {

        }
        public Controlador(int id)
        {
            _id = id;
            _listaBotones = new List<Boton>();
        }
        //1 - Agregar botón
        public void AgregarBoton(int id, string descripcion)
        {
            Boton B = new Boton(id, descripcion);
            _listaBotones.Add(B);           
        }
        //2 - Eliminar botón
        //3 - Mostrar descripción
        //4 - Listar botones
        public void ListarBotones()
        {
            int id;
            string desc;
            foreach(Boton B in _listaBotones)
            {
                id = B.Id;
                desc = B.Descripcion;
                
            }
        }

        //5 - Salir        
        //public bool Salir
        //{
        public void SeleccionarOpcion(int id) 
        {
            if (id > 5)
            {
                throw new ValorInvalidoEx();
            }
           
        }
        //}

    }
}

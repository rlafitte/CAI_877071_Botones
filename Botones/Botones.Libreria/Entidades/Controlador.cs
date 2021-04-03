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
        public List<Boton> _listaBotones;

        public Controlador()
        {
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
        public void ListarBotones(out string msg)
        {
            msg = "";
            foreach (Boton B in _listaBotones)
            {
                msg += B.Id + "||" + B.Descripcion + Environment.NewLine;
            }
        }

        //5 - Salir        
        //public void Salir

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

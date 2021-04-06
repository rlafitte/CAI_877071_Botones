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
        public void EliminarBotón(int id, out string msg)
        {
            msg = "";
            Boton BorrarId;
            try
            {
            BorrarId = _listaBotones.FirstOrDefault(i => i.Id == id);
                try
                {
                    _listaBotones.Remove(BorrarId);
                    msg = "El botón " + BorrarId.Id + " ha sido eliminado.";
                }
                catch
                {
                    msg = "Elemento no borrado" + Environment.NewLine;
                }
            }
            catch
            {
                msg = "ID no encontrado" + Environment.NewLine;
            }
            return;
        }
        //3 - Mostrar descripción
        public void MostrarDescripción(int id, out string msg)
        {
            msg = "";
            Boton Desc;
            try
            {
                Desc = _listaBotones.FirstOrDefault(i => i.Id == id);
                try
                {
                msg = Desc.Descripcion;
                }
                catch
                {
                msg = "ID no encontrado" + Environment.NewLine;

                }
            }
            catch
            {
                msg = "ID no encontrado" + Environment.NewLine;
            }
            return;
        }
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
        //public bool
        public void Salir(string tecla, out bool flag)
        {
            //tecla = Console.ReadKey().Key;
            flag = true;
            if(tecla == "S")
            {
                flag = false;
            }
            else if(tecla == 5.ToString())
            {
                flag = false;
            }
            
        }

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

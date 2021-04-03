using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botones.Libreria.Entidades;
using Botones.Libreria.Excepciones;

namespace Botones.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solución en 2 proyectos.
            //- Consola: un menú donde el usuario pueda seleccionar la opción deseada entre(listar botones, 
            //    agregar botón, eliminar botón, mostrar descripción, salir)
            //- Proyecto de librería: clase controlador, clase botón

            //- El programa sólo debe terminar si el usuario quiere salir.
            //- NO usar console.writeline en las clases dentro de libreria.Deben manejarlo con throw y 
            //    try/catch en la consola.
            //- Hacer una exception custom(ej.BotonYaExistenteException)
            bool flag = true;
            string _resp;
            int i_resp;
            int id;
            string desc;
            string msg = "";
            Controlador Ctrl = new Controlador();
            while (flag)
            {

            Console.WriteLine("Por favor ingrese la opción deseada: " + Environment.NewLine +
                "1 - Agregar botón" + Environment.NewLine +
                "2 - Eliminar botón" + Environment.NewLine +
                "3 - Mostrar descripción" + Environment.NewLine +
                "4 - Listar botones" + Environment.NewLine +
                "5 - Salir" + Environment.NewLine
                );
                _resp = Console.ReadLine();
                try
                {
                    i_resp = Int32.Parse(_resp);
                    Ctrl.SeleccionarOpcion(i_resp);
                    switch (i_resp)
                    {
                        case 1: //Agregar botón
                                Console.WriteLine("Ingrese el ID del botón a agregar: ");
                            try
                            {
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese la descripción a agregar: ");
                                try
                                {
                                  desc = Console.ReadLine();
                                  Ctrl.AgregarBoton(id, desc);
                                }
                                catch
                                {

                                }  
                            }
                            catch
                            {
                                Console.WriteLine("El valor no es numérico.");
                            }
                            break;

                        case 2: //Eliminar botón
                        case 3: //Mostrar descripción
                        case 4: //Listar botones

                            Ctrl.ListarBotones(out msg);
                            Console.WriteLine(msg);
                            break;
                        case 5: //Salir
                        default:
                                break;
                            
                    }
                    
            
                }
                catch (ValorInvalidoEx vin)
                {
                    Console.WriteLine("El valor ingresado no es válido. Intente nuevamente.");                   
                }
                catch
                {
                    Console.WriteLine("Ocurrió un error inesperado.");
                }

            Console.WriteLine("¿Desea salir? S/N");
            //flag = Console.ReadLine();
            }
        }
        }
}

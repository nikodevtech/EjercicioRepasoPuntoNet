using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.servicios
{
    /// <summary>
    /// Clase que implementa la interfaz menú y es donde se detalla la funcionalidad 
    /// concreta de los métodos de dicha interfaz.
    /// </summary>
    internal class MenuImpl : MenuInterface
    {
        public int MostrarMenu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\t\t\tAlumno: Nicolás Álvarez Zapata");
                Console.WriteLine("\t\t\t╔══════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU             ║");
                Console.WriteLine("\t\t\t╠══════════════════════════════╣");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    1.- Registro empleado     ║");
                Console.WriteLine("\t\t\t║    2.- Modificar empleado    ║");
                Console.WriteLine("\t\t\t║    3.- Mostrar empleados     ║");
                Console.WriteLine("\t\t\t║    4.- Exportar a fichero    ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║          0) Salir            ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t╚══════════════════════════════╝");
                Console.Write("\t\t\tIntroduce la opción deseada: ");
                opcion = Console.ReadKey(true).KeyChar - '0';

                if (opcion < 0 || opcion > 4)               
                    Console.WriteLine("\n\t** Error la opcion introducida no se encuentra entre 0 y 4 **");
                
            } while (opcion < 0 || opcion > 4);

            return opcion;
        }
    }
}

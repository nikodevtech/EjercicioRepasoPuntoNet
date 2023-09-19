using EjercicioRepaso.entidades;
using EjercicioRepaso.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioRepaso
{
    /// <summary>
    ///  Clase Main que es por donde inicia la aplicación, solo estan definidos el procedimiento de ejecución que sigue la aplicación.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cerrarMenu = false;
            int opcion;

            //Lista que actua como bbdd empleados en al aplicación
            List<Empleado> listaEmpleados = new List<Empleado>(); 

            MenuInterface menuInterface = new MenuImpl();
            ControlEmpleadoInterface controlEmpleadoInterface = new ControlEmpleadoImpl();

            do
            {
                opcion = menuInterface.MostrarMenu();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        controlEmpleadoInterface.RegistroEmpleado(listaEmpleados);
                        break;
                    case 2:
                        controlEmpleadoInterface.ModificarEmpleado(listaEmpleados);
                        break;
                    case 3:
                        controlEmpleadoInterface.MostrarEmpleados(listaEmpleados);
                        break;
                    case 4:
                        break;
                    case 0:  
                        cerrarMenu = Util.PreguntaSiNo("¿Confirma que quiere cerrar la aplicación? (S=si / N=no): "); ;
                        break;
                }

                if (opcion != 0)
                    Util.Pausa("volver al Menú");

            } while (!cerrarMenu);

            Util.Pausa("salir y desconectar");
        }
    }
}

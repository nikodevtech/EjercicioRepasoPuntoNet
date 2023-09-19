using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.servicios
{
    /// <summary>
    /// Interfaz que tiene solo la cabecera (sin entrar en detalle) de los métodos que dan servicio al menú.
    /// </summary>
    internal interface MenuInterface
    {
        /// <summary>
        /// Método encargado de mostrar al usuario un menú por consola con las opciónes disponibles 
        /// </summary>
        /// <returns>Número entero en relación a la opción seleccionada</returns>
        int MostrarMenu();
    }
}

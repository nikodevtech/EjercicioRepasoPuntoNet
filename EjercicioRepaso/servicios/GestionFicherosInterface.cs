using EjercicioRepaso.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.servicios
{
    /// <summary>
    /// Interfaz que tiene la cabecera de los métodos que dan servicio a la gestión
    /// de ficheros.
    /// </summary>
    internal interface GestionFicherosInterface
    {
        /// <summary>
        /// Se dará la opción de exportar a fichero un empleado identificando por su Nº de empleado 
        /// o toda la lista. En ambos caso con todos los datos del empleado menos el Nº de cuenta bancaria y el Nº de la seguridad social
        /// separando cada campo por ; entre ellos.
        /// </summary>
        /// <param name="listaEmpleados"></param>
        void ExportarFichero(List<Empleado> listaEmpleados);
    }
}

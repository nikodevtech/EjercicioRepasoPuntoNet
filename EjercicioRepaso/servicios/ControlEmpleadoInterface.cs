using EjercicioRepaso.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.servicios
{
    /// <summary>
    /// Interfaz que define la cabecera de los métodos que se tendrán que implementar para 
    /// dar servicio a todo lo relacionado con los empleados.
    /// </summary>
    internal interface ControlEmpleadoInterface
    {
        /// <summary>
        /// Método encargado de pedir los datos del nuevo empleado para el registro
        /// </summary>
        /// <param name="listaEmpleados">La lista con los empleados registrados</param>
        void RegistroEmpleado(List<Empleado> listaEmpleados);

        /// <summary>
        /// Método encargado de pedir los datos a modificar del empleado ya registrado
        /// </summary>
        /// <param name="listaEmpleados">Lista con los empleados registrados</param>
        void ModificarEmpleado(List<Empleado> listaEmpleados);

        /// <summary>
        /// Método que itera la lista con los empleados para poder mostrar sus datos
        /// </summary>
        void MostrarEmpleados(List<Empleado> listaEmpleados);

        
    }
}

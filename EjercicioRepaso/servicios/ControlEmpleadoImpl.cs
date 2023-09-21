using EjercicioRepaso.entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.servicios
{
    /// <summary>
    /// Clase que implementa la interfaz que da servicio a la gestión de empleados,
    /// en ella es donde se detalla la funcionalidad concreta de los métodos de dicha interfaz.
    /// </summary>
    internal class ControlEmpleadoImpl : ControlEmpleadoInterface
    {
        public void RegistroEmpleado(List<Empleado> listaEmpleados)
        {
            string nombre, apellidos, dni, fechaNacimiento, titulacion, numCuentaBancaria;
            int numEmpleado, numSeguridadSocial;

            Console.WriteLine("\n\t\t --- Registro nuevo empleado ---");

            numEmpleado = CrearID(listaEmpleados);
            Console.Write("\n\tNombre: ");
            nombre = Console.ReadLine();
            Console.Write("\n\tApellidos: ");
            apellidos = Console.ReadLine();
            Console.Write("\n\tDNI: ");
            dni = Console.ReadLine();
            Console.Write("\n\tFecha de nacimiento: ");
            fechaNacimiento = Console.ReadLine();
            Console.Write("\n\tTitulación mas alta: ");
            titulacion = Console.ReadLine();
            Console.Write("\n\tIBAN: ");
            numCuentaBancaria = Console.ReadLine();
            numSeguridadSocial = Util.CapturaEntero("Número de Seguridad social", 1 , 999999999);

            listaEmpleados.Add(new Empleado(numEmpleado, nombre, apellidos, dni, fechaNacimiento, titulacion, numSeguridadSocial, numCuentaBancaria));
            Console.Clear();
            Console.WriteLine("\n\t** Empleado registrado correctamente en el sistema!! **");
        }

        public void ModificarEmpleado(List<Empleado> listaEmpleados)
        {
            int numEmpleado;
            if(listaEmpleados.Count != 0)
            {
                numEmpleado = Util.CapturaEntero("\n\tIntroduce el número de empleado a modificar",1,listaEmpleados.Count);

                int posicionEmpleado=0;

                //Iteramos para encontrar en que posición está en la lista está el empleado elegido por el usuario
                for (int i=0;i<listaEmpleados.Count;i++) 
                {
                    if (listaEmpleados[i].NumEmpleado == numEmpleado)
                        posicionEmpleado = i;
                }

                Console.WriteLine("\n\t1. Nombre\n\t2. Apellidos\n\t3. DNI\n\t4. Fecha de nacimiento\n\t5. Titulación\n\t6. Número Seguridad Social\n\t7. IBAN bancario");

                int campoSeleccionado = Util.CapturaEntero("Introduce el número del campo que quiere modificar: ",1,7);
                switch (campoSeleccionado)
                {
                    case 1:
                        Console.Write("\n\tNuevo nombre: ");
                        string nombre = Console.ReadLine();
                        listaEmpleados[posicionEmpleado].Nombre = nombre;
                        break;
                    case 2:
                        Console.Write("\n\tNuevos apellidos: ");
                        string apellidos = Console.ReadLine();
                        listaEmpleados[posicionEmpleado].Apellidos = apellidos;

                        break;
                    case 3:
                        Console.Write("\n\tNuevo DNI: ");
                        string dni = Console.ReadLine();
                        listaEmpleados[posicionEmpleado].Dni = dni;
                        break;
                    case 4:
                        Console.Write("\n\tNuevo fecha nacimiento: ");
                        string fechaNacimiento = Console.ReadLine();
                        listaEmpleados[posicionEmpleado].FechaNacimiento = fechaNacimiento;
                        break;
                    case 5:
                        Console.Write("\n\tNueva titulación: ");
                        string titulacion = Console.ReadLine();
                        listaEmpleados[posicionEmpleado].Titulacion = titulacion;
                        break; 
                    case 6:
                        Console.Write("\n\tNuevo número Seguridad Social: ");
                        int numSeguridadSocial = Util.CapturaEntero("Número de Seguridad social", 1, 999999999);
                        listaEmpleados[posicionEmpleado].NumSeguridadSocial = numSeguridadSocial;
                        break; 
                    case 7:
                        Console.Write("\n\tNuevo IBAN bancario: ");
                        string iban = Console.ReadLine();
                        listaEmpleados[posicionEmpleado].NumCuentaBancaria = iban;  
                        break;
                    default:
                        Console.WriteLine("Campo no válido");
                        break;
                }
                Console.WriteLine("\n\t** Empleado modificado correctamente **");
            }
        }

        public void MostrarEmpleados(List<Empleado> listaEmpleados)
        {
            if (listaEmpleados.Count != 0)
            {
                foreach (Empleado e in listaEmpleados)           
                    e.MostrarDatos();    
            }
            else
                Console.WriteLine("\n\t** No hay empleados registrados en el sistema **");
        }

        /// <summary>
        /// Genera un identificador unívoco por cada nuevo empleado registrado en el sistema
        /// </summary>
        /// <param name="listaEmpleados">Lista con los empleados registrados</param>
        /// <returns>Número entero usado para identificar al empleado</returns>
        private int CrearID(List<Empleado> listaEmpleados)
        {

            int idMayor = 0;

            if (listaEmpleados.Count == 0)
                return 1;
            else
            {
                foreach (Empleado empleado in listaEmpleados)
                {
                    if (empleado.NumEmpleado > idMayor)
                        idMayor = empleado.NumEmpleado;
                }
                
                return ++idMayor;
            }
        }
    }
}

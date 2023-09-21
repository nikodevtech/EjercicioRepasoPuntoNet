using EjercicioRepaso.entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.servicios
{
    /// <summary>
    /// Clase que implementa la interfaz para la gestión del tratamiento de fichero,
    /// en ella se definen el detalle y la funcionalidad de dichos métodos.
    /// </summary>
    internal class GestionFicherosImpl : GestionFicherosInterface
    {
        public void ExportarFichero(List<Empleado> listaEmpleados)
        {
            //Declaramos un stream de escritura, el cual cuando escriba se crea el fichero en la
            //ruta por defecto del proyecto (bin/debug/FicheroEmpleados.txt)
            StreamWriter sW = File.CreateText("FicheroEmpleados.txt");

            if (listaEmpleados.Count != 0)
            {
                if (Util.PreguntaSiNo("Quiere exportar todos los empleados (S=si / N=no)"))
                {
                    foreach (Empleado e in listaEmpleados)
                    {
                        sW.WriteLine("{0};{1};{2};{3};{4}", e.Nombre, e.Apellidos, e.Dni, e.FechaNacimiento, e.Titulacion);
                    }
                }
                else
                {
                    int numEmpleadoExportar = Util.CapturaEntero("Introduce el nº de empleado a exportar",1,listaEmpleados.Count);
                    int posicionEmpleado = 0;

                    //Iteramos para encontrar en que posición en la lista está el empleado elegido por el usuario
                    for (int i = 0; i < listaEmpleados.Count; i++)
                    {
                        if (listaEmpleados[i].NumEmpleado == numEmpleadoExportar)
                            posicionEmpleado = i;
                    }

                    sW.WriteLine("{0};{1};{2};{3};{4}", 
                        listaEmpleados[posicionEmpleado].Nombre, listaEmpleados[posicionEmpleado].Apellidos,
                        listaEmpleados[posicionEmpleado].Dni, listaEmpleados[posicionEmpleado].FechaNacimiento,
                        listaEmpleados[posicionEmpleado].Titulacion);
                }
                sW.Close();
                Console.WriteLine("\n\n\t** Fichero creado correctamente en la carpeta por defecto del proyecto **");
            }
            else
            {
                Console.WriteLine("\n\n\t** No se puede exportar fichero sin ningun empleado registrado en el sistema **");
            }
            
        }
    }
}

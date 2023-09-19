using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso
{
    /// <summary>
    /// Clase Util que contiene varios métodos de utilidades y static que no pertenecen a ninguna clase
    /// </summary>
    internal class Util
    {
        /// <summary>
        /// Método que pide un número entero al usuario y controla que no tenga error con el tipo de dato introducido
        /// </summary>
        /// <param name="mensaje">Texto informativo para mostrar al usuario</param>
        /// <param name="max">Número entero máximo que puede introducir</param>
        /// <param name="min">Número entero mínimo que puede introducir</param>
        /// <returns>El número entero sin errores introducido</returns>
        public static int CapturaEntero(string mensaje, int min, int max)
        {
            int valor = 0;
            bool esCorrecto = false;
            do
            {
                Console.Write("\n\t{0}: ", mensaje);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto) 
                    Console.WriteLine("\n\t** Error debe introducir un número entero  **");
                else if (valor < min || valor > max)
                    Console.WriteLine("\n\t** Error el número introducido no es correcto  **");

            }
            while (!esCorrecto || valor < min || valor > max);

            return valor;
        }

        /// <summary>
        /// Método que pide un al usuario confirmar una acción realizada con S o N
        /// </summary>
        /// <param name="pregunta">Texto informativo para el user</param>
        /// <returns>True si confirma la acción y false en caso contrario</returns>
        public static bool PreguntaSiNo(string pregunta)
        {
            char respuesta;
            do
            {
                Console.Write("\n\t{0}?: ", pregunta);
                respuesta = Console.ReadKey().KeyChar;

                if (respuesta != 'S' && respuesta != 's' && respuesta != 'N' && respuesta != 'n')
                    Console.WriteLine("\n\n\t** Error ** Debes responder con S o N (S=si / N=no) **");

            } while (respuesta != 'S' && respuesta != 's' && respuesta != 'N' && respuesta != 'n');

            if (respuesta == 'S' || respuesta == 's')
                return true;
            else
                return false;

        }

        /// <summary>
        /// Método que permite realizar pausa en la consola evitando que borre lo que se muestra o que la cierre sin previo aviso
        /// </summary>
        /// <param name="mensaje">Texto informativo para el user</param>
        public static void Pausa(string mensaje)
        {
            Console.Write("\n\n\tPulse una tecla para {0}", mensaje);
            Console.ReadKey(true);
        }
    }
}

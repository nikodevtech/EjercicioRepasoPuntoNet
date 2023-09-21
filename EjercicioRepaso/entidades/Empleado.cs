using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.entidades
{
    /// <summary>
    /// Clase que representa a la entidad Empleado, contiene atributos, constructor, propiedades y los getter & setter.
    /// </summary>
    internal class Empleado
    {

        //Atributos
        int numEmpleado;
        string nombre;
        string apellidos;
        string dni;
        string fechaNacimiento;
        string titulacion;
        int numSeguridadSocial;
        string numCuentaBancaria;

        //Constructor
        public Empleado(int numEmpleado, string nombre, string apellidos, string dni, string fechaNacimiento, string titulacion, int numSeguridadSocial, string numCuentaBancaria)
        {
            this.NumEmpleado = numEmpleado;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.FechaNacimiento = fechaNacimiento;
            this.Titulacion = titulacion;
            this.NumSeguridadSocial = numSeguridadSocial;
            this.NumCuentaBancaria = numCuentaBancaria;
        }

        //Propiedades getter y setter
        public int NumEmpleado { get => numEmpleado; set => numEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Titulacion { get => titulacion; set => titulacion = value; }
        public int NumSeguridadSocial { get => numSeguridadSocial; set => numSeguridadSocial = value; }
        public string NumCuentaBancaria { get => numCuentaBancaria; set => numCuentaBancaria = value; }

        /// <summary>
        /// Método que muestra por consola todos los datos del empleado
        /// </summary>
        public void MostrarDatos()
        {
            Console.Write("\n\n\t--- Datos del empleado con Nº{7} ---\n\n\tNombre y apellidos: {0} {1}\n\tDNI: {2}\n\tFecha de nacimiento: {3}\n\tTitulación: {4}\n\tNúmero Seguridad Social: {5}\n\tNúmero de empleado: {6}", Nombre, Apellidos, Dni, FechaNacimiento, Titulacion, NumSeguridadSocial, NumEmpleado, NumEmpleado);
        }
        
    }
}

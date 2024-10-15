using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NazaretAlestonP1.Model
{
    public class Persona
    {
        // Propiedades de la clase Persona
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public int Edad { get; set; }

        // Constructor de la clase Persona para inicializar las propiedades
        public Persona(string identificacion, string nombre, string apellido, string correoElectronico, int edad)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            CorreoElectronico = correoElectronico;
            Edad = edad;
        }

        // Método ToString para devolver una representación de las propiedades
        public override string ToString()
        {
            return $"Identificación: {Identificacion}, Nombre: {Nombre}, Apellido: {Apellido}, Correo: {CorreoElectronico}, Edad: {Edad}";
        }
    }

    // Clase derivada Estudiante que hereda de Persona
    public class Estudiante : Persona
    {
        // Propiedad específica del estudiante
        public string Carrera { get; set; }
        public int AñoIngreso { get; set; }

        // Constructor que utiliza el constructor de la clase base y añade propiedades adicionales
        public Estudiante(string identificacion, string nombre, string apellido, string correoElectronico, int edad, string carrera, int añoIngreso)
            : base(identificacion, nombre, apellido, correoElectronico, edad)
        {
            Carrera = carrera;
            AñoIngreso = añoIngreso;
        }

        // Método ToString para devolver una representación de las propiedades
        public override string ToString()
        {
            return base.ToString() + $", Carrera: {Carrera}, Año de Ingreso: {AñoIngreso}";
        }
    }

    // Clase derivada Profesor que hereda de Persona
    public class Profesor : Persona
    {
        // Propiedad específica del profesor
        public string Departamento { get; set; }
        public int AñosExperiencia { get; set; }

        // Constructor que utiliza el constructor de la clase base y añade propiedades adicionales
        public Profesor(string identificacion, string nombre, string apellido, string correoElectronico, int edad, string departamento, int añosExperiencia)
            : base(identificacion, nombre, apellido, correoElectronico, edad)
        {
            Departamento = departamento;
            AñosExperiencia = añosExperiencia;
        }

        // Método ToString para devolver una representación de las propiedades
        public override string ToString()
        {
            return base.ToString() + $", Departamento: {Departamento}, Años de Experiencia: {AñosExperiencia}";
        }
    }

    // Clase derivada Usuario que hereda de Persona
    public class Usuario : Persona
    {
        // Propiedad específica del usuario
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }

        // Constructor que utiliza el constructor de la clase base y añade propiedades adicionales
        public Usuario(string identificacion, string nombre, string apellido, string correoElectronico, int edad, string nombreUsuario, string rol)
            : base(identificacion, nombre, apellido, correoElectronico, edad)
        {
            NombreUsuario = nombreUsuario;
            Rol = rol;
        }

        // Método ToString para devolver una representación de las propiedades
        public override string ToString()
        {
            return base.ToString() + $", Nombre de Usuario: {NombreUsuario}, Rol: {Rol}";
        }
    }
}
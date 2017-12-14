using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceramicApp
{
    public class Usuario
    {
        private string Nombre;
        private string NombreUsuario;
        private string Contrasena;
        private string Tipo;
        private string Especialidad;
        private string Departamento;



        public Usuario(string nombre, string nombreU, string contrasena, string tipo, string especialidad, string departamento)
        {
            Nombre = nombre;
            NombreUsuario = nombreU;
            Contrasena = contrasena;
            Tipo = tipo;
            Especialidad = especialidad;
            Departamento =departamento;
        

          
        }
        public string pNombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public string pUsuario
        {
            get
            {
                return NombreUsuario;
            }
            set
            {
                NombreUsuario = value;
            }
        }
        public string pContrasena
        {
            get
            {
                return Contrasena;
            }
            set
            {
                Contrasena = value;
            }
        }
        public string pTipo
        {
            get
            {
                return Tipo;
            }
            set
            {
                Tipo = value;
            }
        }
        public string pEspecialidad
        {
            get
            {
                return Especialidad;
            }
            set
            {
                Especialidad = value;
            }
        }
        public string pDepartamento
        {
            get
            {
                return Departamento;
            }
            set
            {
                Departamento = value;
            }
        }

    }
}

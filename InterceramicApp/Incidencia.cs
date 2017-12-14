using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceramicApp
{
    class Incidencia
    {
        private string Usuario;
        private string Tipo;
        private string Prioridad;
        private string Estatus;
        private string Descripcion;
        private string Dispositivo;
        private string Departamento;
        private string Tecnico;

        public Incidencia(string usuario, string tipo, string prioridad, string estatus, string descripcion,string dispositivo, string departamento, string tecnico)
        {
            Usuario = usuario;
            Tipo = tipo;
            Prioridad = prioridad;
            Estatus = estatus;
            Dispositivo = dispositivo;
            Descripcion = descripcion;
            Departamento = departamento;
            Tecnico = tecnico;
        }
        public string pUsuario
        {
            get
            {
                return Usuario;
            }
            set
            {
                Usuario = value;
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
        public string pPrioridad
        {
            get
            {
                return Prioridad;
            }
            set
            {
                Prioridad = value;
            }
        }
        public string pEstatus
        {
            get
            {
                return Estatus;
            }
            set
            {
                Estatus = value;
            }
        }
        public string pDispositivo
        {
            get
            {
                return Dispositivo;
            }
            set
            {
                Dispositivo = value;
            }
        }
        public string pDescripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
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
        public string pTecnico
        {
            get
            {
                return Tecnico;
            }
            set
            {
                Tecnico = value;

            }
        }
    }
}



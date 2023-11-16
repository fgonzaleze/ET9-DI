using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     internal class clsPersona
    {
        #region atributos
        private int id;
        private string nombre;
        private string apellidos;
        private int edad;
        #endregion

        #region constructores
        public clsPersona() { }

        public clsPersona(int id, string nombre, string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }
        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; } 
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
 
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        #endregion

    }
}

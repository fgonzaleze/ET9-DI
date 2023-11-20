using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E4T9.Viewmodels
{
    
    public class clsViewModelTroleo : INotifyPropertyChanged
    {

        // Atributos privados que almacenarán el nombre y el apellido
        #region atributos
        private string nombre;
        private string apellidos;
        #endregion

        #region constructores
        public clsViewModelTroleo() { } // Constructor sin parámetros
        public clsViewModelTroleo(string nombre, string apellidos) // Constructor con el nombre y el apellido
        {
            this.apellidos = apellidos;
            this.nombre = nombre;
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;

                if (nombre.Contains("n")) // Si el nombre tiene n
                {
                    apellidos = string.Empty; // Vaciamos el apellido
                    OnPropertyChanged("Apellidos");
                }
            }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                apellidos = value;
                if (apellidos.Contains("n")) // Si el apellido contiene la n
                {
                    nombre = string.Empty; // Vaciamos el nombre
                    OnPropertyChanged("Nombre");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string atributo = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(atributo));
        }
        #endregion
    }

}

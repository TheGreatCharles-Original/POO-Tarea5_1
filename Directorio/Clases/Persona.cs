using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.Clases
{
    internal class Persona
    {
        private string names { set; get; }   // Por defecto son privados, para utilizarlos en otra clase, hay que cambiarlos a public
        public string lastnames { set; get; }
        public int age { set; get; }
        public string address { set; get; }
        public string phonenumber { set; get; }
        public string email { set; get; }
        public DateTime birthDate { set; get; }

        public Persona() // Constructor
        {
            this.names = "Juan"; // Esto es un constructor se usa para inicializar variables
        }

        public string getName() // Esto crea un metodo o funcion sirve para logica interna
        {
            return this.names;
        }

        public void setName(string p_names ) // Esto hace lo mismo pero no devuelve nada
        {
            this.names = p_names;
        }
    }
}

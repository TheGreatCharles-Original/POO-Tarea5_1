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
        private string numid { set; get; } // no me dio ningun error por eso no utilice el numid


        public Persona() // Constructor
        {
            this.names = "Juan"; // Esto es un constructor se usa para inicializar variables
        }

        public Persona(string p_name)
         {
             this.names = p_name; 
         }

        public Persona(string p_name, string p_lastname)
        {
            this.names = p_name;
            this.lastnames = p_lastname;
        }


        public string getName() // Esto crea un metodo o funcion sirve para logica interna
        {
            return this.names;
        }

        public void setName(string p_name ) // Esto hace lo mismo pero no devuelve nada
        {
            this.names = p_name;
        }

        public void setlastname(string p_lastname) // Esto hace lo mismo pero no devuelve nada
        {
            this.lastnames = p_lastname;
        }

        public string getFullName(string p_name, string p_lastname) // Esto hace lo mismo pero no devuelve nada
        {
            this.names = p_name;
            this.lastnames = p_lastname;

            return this.names + " " + this.lastnames;
        }

        public string getFullName() // Esto hace lo mismo pero no devuelve nada
        {
            return this.names + " " + this.lastnames;
        }


        /* public string getFullName(string p_name, string p_lastname) // Esto hace lo mismo pero no devuelve nada
         {

             return  this.names + " " + this.lastnames;

         }*/

        /* public void setName(string p_names, string p_lastname) // Esto hace lo mismo pero no devuelve nada
         {
             this.names = p_names;
             this.lastnames = p_lastname;
         }*/

    }
}

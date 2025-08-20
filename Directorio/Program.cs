using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Directorio.Clases; // se crea automaticamente 

namespace Directorio
{
    internal class Program // La clase principal es esta, las demas son subclases
    {
        static void Main(string[] args)
        {
            Persona person = new Persona();// Se crea el objeto o se instancia, de preferencia se crea el objeto
            person.setName("Solis");

            WriteLine(person.getName());
            ReadLine();


            /*person.names = "";
            person.lastnames = "";*/

        }
    }
}
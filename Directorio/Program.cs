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

            List<string> fruit = new List<string>(); // List permite guardar muchos objetos

            fruit.Add("I have a Apple");
            fruit.Add("I have a Pen");

            WriteLine(fruit[0]);
            WriteLine(fruit[1]);

            foreach (string fruits in fruit) // Es un ciclo for que recorre todos los elementos de la lista
            {
                WriteLine(fruits);
            }

            List<Persona> persons = new List<Persona>(); // List permite guardar muchos objetos

            fruit.Add("I have a Apple");
            fruit.Add("I have a Pen");

            WriteLine(fruit[0]);
            WriteLine(fruit[1]);

            Persona person = new Persona();// Se crea el objeto o se instancia, de preferencia se crea el objeto
            person.setName("Solis");       // Doble click para los breakpoint que son pausas

            WriteLine(person.getName());
            ReadLine();


            /*person.names = "";
            person.lastnames = "";*/

        }
    }
}
using static System.Console; // es como el std:: del c++ mejor omitirlo
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Calculator // Una funcion que me permitiria usar Calculator en otro proyecto
{
    internal class Program
    {
        static void Main(string[] args) // Esto crea un argumento con el nombre args, que es de texto
        {
            string name;
            string lastname;

            int WholeNumber = 5;
            double DecimalNumber = 2.5; // Para decimales
            double addition = 0;
            double subtraction = 0;
            double division = 0;
            double multiplication = 0;

            double div1 = 5 / 2, div2 = 5.0 / 2.0, div3 = 5.0 / 2;

            WriteLine($"The division result is {div1},{div2},{div3} ");

            addition = WholeNumber + DecimalNumber;
            subtraction = WholeNumber - DecimalNumber;
            division = WholeNumber / DecimalNumber;
            multiplication = WholeNumber * DecimalNumber;

            name = "September ";
            lastname = "December 1999";

            WriteLine("Hello World, i am " + name + lastname ); // Concatenacion para agregar una variable se usa +
            WriteLine($"Hello World,i am {name }{lastname} "); // Interpolacion en lugar de escribir + se usan llaves {

            WriteLine("The sum is " + addition); /* */ //comentario multilenea
            WriteLine($"The sum is {addition}");
            WriteLine($"the subtraction is {subtraction}");
            WriteLine($"The division is {division}");
            WriteLine($"The multiplication is {multiplication}");
            ReadLine();
        }
    }
}

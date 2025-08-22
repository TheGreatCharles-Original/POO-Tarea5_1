using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.Clases
{
    public class Marcador
    {
        private double CostHou {  get; set; }
        private double WorkedHours { get; set; }
        private double Salary {  get; set; }

        public Marcador()
        {
            this.CostHou = 50;
        }

        public double getSalary(double p_WorkedHours)
        {
            this.Salary = p_WorkedHours*this.CostHou;
            return this.Salary;

        }
       
    }
}

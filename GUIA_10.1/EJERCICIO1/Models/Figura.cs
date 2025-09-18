using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2.Models
{
    abstract public class Figura
    {
        public int Id { get; set; }
        public double Area {  get; set; }
        public Figura() { }
        public Figura(double area) { this.Area = area; }
    }
}

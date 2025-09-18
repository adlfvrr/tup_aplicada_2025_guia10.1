using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2.Models
{
    public class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public Rectangulo() { }
        public Rectangulo(double ancho, double largo, double area) : base(area) { }
    }
}

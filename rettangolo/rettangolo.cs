using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rettangolo
{
    internal class rettangolo
    {
        public int L1 { get; set; }

        public int L2 { get; set; }

        public int area { get; set; }

        public int perimetro { get; set; }
       
        
        public int calcoloarea(int area)
        {
            area = L1 * L2;

            return area;
        }
        
        public int calcolaperimetro(int perimetro)
        {
            perimetro = (L1 + L2) *2;

            return perimetro;
        }
    }
}

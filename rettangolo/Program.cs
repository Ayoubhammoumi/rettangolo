using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rettangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rettangolo rettangolo= new rettangolo();

            rettangolo.L1 = 3;
            rettangolo.L2 = 4;

            Console.WriteLine("{0}",rettangolo.calcoloarea(rettangolo.area));

            Console.WriteLine("{0}", rettangolo.calcolaperimetro(rettangolo.perimetro));

            Console.ReadLine();
        }
    }
}

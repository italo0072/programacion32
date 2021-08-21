using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercisio
{
    public class Class1
    {
        

        public static void sortedListColletion()
        {

            double c;
            double RESUL;
            string linea;
            Console.Write("grados ºC : "); linea = Console.ReadLine();
            c = int.Parse(linea);
            RESUL = (c * 9 / 5) + 32;
            Console.WriteLine();
            Console.WriteLine("El Resultado es " + RESUL + "ºF");
            Console.ReadLine();
        }
    }
}

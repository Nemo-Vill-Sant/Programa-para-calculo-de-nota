using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_para_calculo_de_nota
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite la primer nota del estudiante");
            double a = 4;

            Console.WriteLine("Digite la segunda nota del estudiante");
            double b = 3;

            Console.WriteLine("Digite la tercera nota del estudiante");
            double c = 3;


            double x = a = 4;
            double y = b = 3;
            double z = c = 3;

            double final = x + y + z;

            Console.WriteLine("Notas a sumar");
            Console.WriteLine("nota 1:" + a );
            Console.WriteLine("Nota 2:" + b);
            Console.WriteLine("Nota 3:" + c);

            Console.WriteLine("Notas sumadas"); ;
            Console.WriteLine("Nota 1:" + x);
            Console.WriteLine("Nota 2:" + y);
            Console.WriteLine("Nota 3:" + z);


            Console.WriteLine("Nota final:" + final);

            Console.WriteLine("Presione Enter para cerrar");

            Console.ReadKey();

        }
    }
}

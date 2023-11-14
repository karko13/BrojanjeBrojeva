using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrojanjeBrojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite neki broj koji zelite da se odbrojava");
            int x = Convert.ToInt32(Console.ReadLine());
            string lista = "";
            for(int i = 1; i < x; i++) 
            {
                lista = lista + i ;
                Console.WriteLine(lista );
            }
            Console.ReadKey();
        }
    }
}

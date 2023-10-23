using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace interfacesExamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarka().ToString());
            Console.WriteLine(focus.KacTekerlek() );
            Console.WriteLine(focus.StandartRengi());

            Console.WriteLine("Diğer araç;");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarka().ToString());
            Console.WriteLine(civic.KacTekerlek());
            Console.WriteLine(civic.StandartRengi());


        }
    }
}



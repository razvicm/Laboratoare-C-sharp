using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasaMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Meteo m = new Meteo();
            m.tempmed();
            Console.WriteLine("Temperatura maxima a lunii este:{0}\n", m.tempmax());
            m.ziuadifmax(1);
            m.zilele();
            m.tempmaxmin();
            Console.ReadKey();
           
        }
    }
}

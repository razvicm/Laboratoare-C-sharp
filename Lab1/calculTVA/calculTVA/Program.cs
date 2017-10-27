using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculTVA
{
    class Program
    {
        static void Main(string[] args)
        {
            int pret, tva_procent;
            float tva, pret_cu_tva;

            try
            {
                Console.Write("pret= ");
                pret = Convert.ToInt16(Console.ReadLine());
                Console.Write("procentul TVA= ");
                tva_procent = Convert.ToInt16(Console.ReadLine());
                tva = pret * (float)tva_procent / 100;
                // operatorul de conversie explicita (float)determina ca rezultatul impartirii sa fie numar real
                pret_cu_tva = pret + tva;
                Console.WriteLine("pretul cu TVA= " + pret_cu_tva);
                // Afisarea prin concatenarea sirului de caractere cu valoarea variabilei
                Console.WriteLine("pret= {0}, procentul TVA= {1}\nvaloarea TVA= {2}, pretul cu TVA = {3}", pret, tva_procent, tva, pret_cu_tva);
                // Afisarea folosind parametri
            }
            catch (Exception exceptie)
            {

                Console.WriteLine(exceptie.Message);
                
            }            Console.ReadKey();
        }
    }
}

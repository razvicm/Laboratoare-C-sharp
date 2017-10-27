using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabInm = new int[20, 7]; // se  pune virgula pt ca sunt 2 indici

            for (int i = 0; i < tabInm.GetLength(0); i++)
            {
                for (int j = 0; j < tabInm.GetLength(1); j++)
                {
                    tabInm[i, j] = i * j;
                }
            }
            Console.WriteLine("Cate un element pe un rand");
            for (int i = 0; i < tabInm.GetLength(0); i++)
            {
                //In fiecare linie parcurgem elementele din coloana 0, 1, 2, ..., 6 (7 coloane)
                for (int j = 0; j < tabInm.GetLength(1); j++)
                {
                    // Afisam numarul liniei (i), numarul coloanei (j), valoarea aflata in matrice pe linia si coloana (i,j): tabInm[i,j]
                    Console.WriteLine("{0}*{1}={2}", i, j, tabInm[i, j]);
                }
            }

            Console.WriteLine("Cate o linie a matricei pe un rand, elementele in format 'currency - moneda'");
            for (int i = 0; i < tabInm.GetLength(0); i++)
            {
                //In fiecare linie parcurgem elementele din coloana 0, 1, 2, ..., 6 (7 coloane)
                for (int j = 0; j < tabInm.GetLength(1); j++)
                {
                    // Afisam elementele, tabInm[i,j] sub forma de tablou bidimensional pe 6 pozitii
                    // {0,10:c} {0=parametrul, 10=nr. pozitii (semn + cifre partea intreaga + virgula + cifre zecimale + un spatiu + moneda), c=currency}
                    Console.Write("{0,10:c} ", tabInm[i, j]);
                }
                // Dupa fiecare linie afisata trecem la rand nou
                Console.WriteLine();
            }

            Console.WriteLine("Matricea pe linii si pe coloane, scriere cu Formataliniere la dreapta");
            for (int i = 0; i < tabInm.GetLength(0); i++)
            {
                //In fiecare linie parcurgem elementele din coloana 0, 1, 2, ..., 6 (7 coloane)
                for (int j = 0; j < tabInm.GetLength(1); j++)
                {
                    // Afisam elementele, tabInm[i,j] sub forma de tablou bidimensional
                    Console.Write("{0,5} ", tabInm[i, j]);
                }
                // Dupa fiecare linie afisata trecem la rand nou
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

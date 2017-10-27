using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace siruri
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarare si instantiere:
            //int[] sir = new int[30];
            // sirul poate fi initializat la declarare:
            //int[] max = new int[] {12,30,24,7,5,5};
            //int[] min = new int[] { 10, 6, 5 ,7,5,5};
            int tmax;
            int tmin;
            int dmax;
            int ziua;
            int zmin;
            int smax;
            int smin;
            int[] max; //declarare sir
            int nmax;
            int[] min;
            int nmin;
            double medmax, medmin;
            Console.Write("Numar de zile: ");
            nmax = Int32.Parse(Console.ReadLine()); //se poate folosi si convert
            nmin = nmax;
            max = new int[nmax]; //instantiere (se aloca spatiu)
            min = new int[nmin];
            for (int i = 0; i < nmax; i++)
            {
                Console.WriteLine("temperatura minima din ziua: " + i);
                min[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("temperatura maxima din ziua: " + i);
                max[i] = Convert.ToInt32(Console.ReadLine());
            }


            
            // Punctul A
            for (int i = 0; i < max.Length; i++)
            {
                double media = (double)(max[i] + min[i]) / 2;
                // Console.WriteLine(Convert.ToString(media)); // afiseaza doar valoarea fiecarei medii
                Console.WriteLine("temperatura media a zilei" + Convert.ToString(i + 1) + " este " + Convert.ToString(media));
            }
            //Punctul b
            tmax = max[0];
            for (int i = 1; i < nmax; i++)
                if (max[i] > tmax)
                    tmax = max[i];
            Console.WriteLine("Temperatura maxima a lunii este:{0}", tmax);
            //Punctul c
            tmax = max[0] - min[0];
            ziua = 0;
            for (int i = 1; i < nmax; i++)
                if (max[i] - min[i] > tmax)
                {
                    tmax = max[i] - min[i];
                    ziua = i;
                }
            Console.WriteLine("Ziua cu cea mai mare diferenta de temperatura este:{0} iar diferenta este de {1}", ziua + 1, tmax);
            //Punctul d
            tmin = min[0];
            // ziua = 0;
            for (int i = 1; i < nmax; i++)
                if (min[i] < tmin)
                {
                    tmin = min[i];
                    // ziua = i;
                    // Console.WriteLine("Ziua cu cea mai scazuta temperatura este:{0} //iar temperatura este de {1}", ziua + 1, tmin);
                    // partea comentata este varianta in care se afiseaza doar prima dintre zilele //cu cea mai scazuta temperatura, chiar daca sunt mai multe
                }
            for (int i = 0; i < nmax; i++)
                if (min[i] == tmin)
                {
                    Console.WriteLine("Ziua cu cea mai scazuta temperatura este:{0} iar temperatura este de {1}", i + 1, tmin);
                }
            //punctul e
            smax = 0;
            smin = 0;
            for (int i = 0; i < nmax; i++)
            {
                smax += max[i];
                smin += min[i];
            }
            medmax = (double)smax / nmax;
            medmin = (double)smin / nmax;
            Console.WriteLine("temperatura medie maxima este " + Convert.ToString(medmax));
            Console.WriteLine("temperatura medie minima este " + Convert.ToString(medmin));
            Console.ReadLine();
        }
    }
}
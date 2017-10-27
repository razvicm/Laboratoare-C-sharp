using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasaMeteo
{
    class Meteo
    {
        private int nmax;
        private int[] max; //declarare sir
        private int[] min;
        public Meteo()
        {
            Console.Write("Numar de zile: ");
            nmax = Int32.Parse(Console.ReadLine());
            max = new int[nmax];
            min = new int[nmax]; //instantiere (se aloca spatiu)
            for (int i = 0; i < nmax; i++)
            {
                Console.WriteLine("temperatura minima din ziua: " + i);
                min[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("temperatura maxima din ziua: " + i);
                max[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public void tempmed()
        {
            for (int i = 0; i < nmax; i++)
            {
                double media = (double)(max[i] + min[i]) / 2;
                Console.WriteLine("temperatura media a zilei" + Convert.ToString(i + 1) + " este " + Convert.ToString(media));
            }
            Console.WriteLine();
        }
        public int tempmax()
        {
            int tmax;
            tmax = max[0];
            for (int i = 1; i < nmax; i++)
                if (max[i] > tmax)
                    tmax = max[i];
            return tmax;
            // Console.WriteLine("Temperatura maxima a lunii este:{0}\n", tmax);
        }
        public void ziuadifmax(int data)
        {
            int tmax, ziua;
            tmax = max[data] - min[data];
            ziua = data;
            for (int i = 1; i < nmax; i++)
                if (max[i] - min[i] > tmax)
                {
                    tmax = max[i] - min[i];
                    ziua = i;
                }
            Console.WriteLine("Ziua cu cea mai mare diferenta de temperatura este:{0} iar diferenta este de {1}\n", ziua + 1, tmax);
        }
        public void ziuadifmax()
        {
            int tmax, ziua;
            tmax = max[0] - min[0];
            ziua = 0;
            for (int i = 1; i < nmax; i++)
                if (max[i] - min[i] > tmax)
                {
                    tmax = max[i] - min[i];
                    ziua = i;
                }
            Console.WriteLine("Ziua cu cea mai mare diferenta de temperatura este:{0} iar diferenta este de {1}\n", ziua + 1, tmax);
        }
        public void zilele()
        {
            int tmin = min[0];
            for (int i = 1; i < nmax; i++)
                if (min[i] < tmin)
                {
                    tmin = min[i];
                }
            for (int i = 0; i < nmax; i++)
                if (min[i] == tmin)
                {
                    Console.WriteLine("Ziua cu cea mai scazuta temperatura este:{0} iar temperatura este de {1}\n", i + 1, tmin);
                }
        }
        public void tempmaxmin()
        {
            int smax, smin;
            double medmax, medmin;
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
            Console.WriteLine("temperatura medie minima este " + Convert.ToString(medmin) + "\n");
        }
    }
}

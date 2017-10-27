using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirCaractere
{
    class Program
    {
        static void Main(string[] args)
        {
            String s3;
            Console.Write("Tastati o propozitie : ");
            s3 = Console.ReadLine();
            Console.WriteLine("Sirul citit = '{0}'", s3);
            // Ordonam alfabetic doua siruri de caractere
            String n1 = "Vasile";
            String n2 = "Vasilache";
            if (String.Compare(n1, n2) < 0) Console.WriteLine("Ordine alfabetica:" + n1 + ", " + n2);
            else if (String.Compare(n1, n2) > 0) Console.WriteLine("Ordine alfabetica:" + n2 + ", " + n1);
            else Console.WriteLine("Au acelasi continut:" + n2 + ", " + n1);
            // Transformare in majuscule
            String s1 = "O, ca sa vezi,nu m-am gandit la asta!";
            String s2 = " Pana acum.";
            s3 = s1.ToUpper();
            Console.WriteLine("Sirul ({0}) cu majuscule = {1}", s1, s3);
            // Alipire a doua texte
            s1 = s1 + s2;
            Console.WriteLine("Sirul concatenat = {0}", s1);
            // Numarare caractere
            // Sirul x format din 5 elemente, caracterele '.', ':', ';', '!', '.' si ','
            // Daca vrem sa numaram vocale sirul va contine 'a' 'e' 'i' 'o' 'u'
            char[] x = { '!', ',', '.', ':', ';' };
            // Numaram cate caractere speciale sunt in text
            int numara = 0;
            for (int i = 0; i < x.Length; i++) // Luam fiecare dintre caracterele speciale
                foreach (char c in s1)
                    if (c == x[i]) numara++;
            Console.WriteLine("Sunt {0} caractere speciale in text", numara);
            // Separarea unui text in cuvintele care-l compun
            // Obtinem un sir de cuvinte
            // Sirul y format din 2 elemente, caracterele 'spatiu' si 'virgula'
            char[] y = { ' ', ',' };
            // In sirul de siruri de caractere String[] cuvinte fiecare element al sirului va contine
            // cate un cuvant din sirul s1. Cuvintele sunt separate pe baza separatorilor aflati in x
            String[] cuvinte = s1.Split(y);
            // Afisarea sirului in ordine inversa
            // Afisam tot cate un cuvant din sirul 'cuvinte'
            Console.WriteLine("cuvintele din propozitia '{0}' scrise in ordine inversa:", s1);
            for (int i = cuvinte.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Cuvantul: '{0}' are {1} caractere", cuvinte[i], cuvinte[i].Length);
            }
            Console.ReadKey();
        
    }
    }
}

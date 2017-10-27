using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persoana
{
    class Angajat : Persoana
    {
        private float salar;
        private string functia;
        public Angajat() { }
        public Angajat(string n, char g, int z, int l, int a, int inal,
        float s, string f)
        {
            nume = n;
            gen = g;
            zi = z;
            luna = l;
            an = a;
            h = inal;
            salar = s;
            functia = f;
        }
        public void Afisare()
        {
            Console.WriteLine("Peroana {0} de genul {1}\n nascuta la data de { 2}/{ 3}/{ 4}\n are varsta: { 5}" +
            "ani si inaltimea { 6}\ngreutatea ideala:{ 7}\n salar:{ 8} functia { 9}"
            , nume, gen, zi, luna, an, Varsta(), h, Greutate(), salar, functia);
        }
    }
}

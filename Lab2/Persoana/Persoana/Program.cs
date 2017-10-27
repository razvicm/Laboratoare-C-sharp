using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Asa folosim proprietatea nume_
        //Persoana pp = new Persoana();
        //pp.nume_ = Console.ReadLine();
        //Console.WriteLine("Ati citit si initializat: " + pp.nume_);
        Persoana p = new Persoana("Andreea", 'f', 22, 11, 1990, 165);
        p.Afisare();
        p.Nume = Console.ReadLine();
        p.Afisare();
        Angajat a = new Angajat("Paul", 'm', 2, 8, 1984, 186, 3500, "manager");
        a.Afisare();
        Console.ReadLine();
    }
}
class Persoana
{
    protected string nume;
    protected char gen;
    protected int zi, luna, an, h;
    public string Nume // Nume este proprietatea pentru atributul nume
    {
        get
        {
            return nume;
        }
        set
        {
            nume = value;
        }
    }
    public Persoana() { }
    public Persoana(string n, char g, int z, int l, int a, int inal)
    {
        nume = n;
        gen = g;
        zi = z;
        luna = l;
        an = a;
        h = inal;
    }
    protected int Varsta()
    {
        DateTime astazi = DateTime.Now;
        int varsta;
        varsta = astazi.Year - an;
        if (astazi.Month < luna) varsta--;
        else if (astazi.Month == luna && astazi.Day < zi) varsta--;
        return varsta;
    }
    protected double Greutate()
    {
        double g;
        g = 50 + 0.75 * (h - 150) + 0.25 * (Varsta() - 20);
        if (gen != 'm')
        {
            g = g * 0.9;
        }
        return g;
    }
    public void Afisare()
    {
        Console.WriteLine("Peroana " + nume + " de genul " + gen +
       "\n nascuta la data de " + zi + " / " + luna + " / " + an + "\n are varsta: " +
        Varsta() + " ani si inaltimea " + h + "\ngreutatea ideala:" + Greutate());
    }
}


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
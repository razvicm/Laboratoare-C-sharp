using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratareaExc
{
    class Program
    {
        static void Main(string[] args)
        {
            short nr = 0, imp;
            double expr;
            try
            {
                Console.Write("Dati impartitorul: ");
                imp = Convert.ToInt16(Console.ReadLine());
                Console.Write("Dati un numar pentru extragerea radacinii patrate: ");
                nr = Convert.ToInt16(Console.ReadLine());
                expr = Math.Sqrt(nr) / imp;
                // definim o exceptie specifica pentru situatia: Nr < 0
                // cu mesajul "Numarul trebuie sa fie pozitiv"
                // aceasta nu este tratata implicit
                // si o exceptie pentru impartire cu zero
                // pe care, daca nu o tratam, ne da ca rezultat: Infinity
                if (nr < 0) throw new Exception("Numarul trebuie sa fie pozitiv");
                else
                if (imp == 0) throw new DivideByZeroException("Impartire cu zero");
                Console.WriteLine("rezultatul calculului este: " + expr);
            }
            catch (FormatException e)// exception handling
            {
                // Tratarea exceptiilor specifice
                // Se trec inaintea exceptiilor generale
                // Aici am tratat o exceptie pentru Convert.ToInt16 de ex introducem abc in loc de cifre
                Console.WriteLine("Scrieti un numar in format corect");
                // Daca vrem sa afiseze mesajul in limba romana, dat de noi
                Console.WriteLine(e.Message); // Mesajul predefinit
            }
            catch (OverflowException e)// exception handling
            {
                // Tratarea exceptiilor specifice
                // Aici am tratat o exceptie pentru Convert.ToInt16 de ex introducem un numarin afara tipului de date short
                Console.WriteLine("Numarul trebuie sa fie cuprins intre -32768 si +32767");
                Console.WriteLine(e.Message);
                // Mesajul predefinit
            }
            // Daca nu am fi specificat cele doua ramuri catch de mai sus,
            // toate erorile ar fi fost prinse pe ramura urmatoare catch (Exception e)
            // cu mesajul predefinit in C# sau un mesaj definit de noi, ca in exemplul:
            // throw new DivideByZeroException("Impartire cu zero");
            catch (DivideByZeroException e)// exception handling
            {
                // Tratarea exceptiilor specifice
                // Aici am tratat o exceptie pentru Convert.ToInt16 de ex introducem abc in loc de cifre
                Console.WriteLine(e.Message);
            }
            catch (Exception e)// exception handling
            {
                // Tratarea exceptiilor generale
                // Orice exceptie, de orice fel, dintre cele predefinite sau definite de noi
                // Exceptii pe care nu le-am specificat mai sus
                // Aici va fi prinsa exceptia de radacina patrata din numar negativ
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Pe aceasta ramura trece si executa indiferent daca
                // a fost exceptie sau executie normala
                Console.WriteLine("Am tratat eventualele erori");
            }
            Console.ReadKey();
        }
    }
}


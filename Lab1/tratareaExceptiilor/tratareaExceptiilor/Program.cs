using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratareaExceptiilor
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nr = 0;
            double sqrt;
            try
            {
                Console.Write("Dati un numar : ");
                Nr = Convert.ToInt32(Console.ReadLine());
                if (Nr <= 0) throw new Exception("Numarul trebuie sa fie pozitiv diferit de zero");
                sqrt = Math.Sqrt(Nr);
                Console.WriteLine("radacina patrata este: " + sqrt);
            }
            catch (FormatException error)// exception handling
            {
                // Tratarea exceptiilor specifice
                Console.WriteLine(error.Message);
            }
            catch (Exception e)// exception handling
            {
                // Tratarea exceptiilor generale
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Am tratat eventualele erori");
            }
            Console.ReadKey();
        }
    }
}

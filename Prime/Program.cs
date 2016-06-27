using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
   public class Program
    {
        public static void Semiprime(int M)
        {
            bool isPrime = true;
            List<int> Lista = new List<int>();
            List<int> SemiPrimes = new List<int>();
            for (int i = 2; i <= M; i++)
            {

                for (int j = 2; j <= M; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                      
                    }
                }
                if (isPrime)
                {                   
                    Lista.Add(i);
                    
                }
                isPrime = true;
                
            }
            Console.WriteLine(string.Join(",", Lista));

            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = 0; j < Lista.Count(); j++)
                {
                    var semiPrime = Lista[i] * Lista[j];
                    if (semiPrime >= M)
                    {
                        break;
                    }

                    SemiPrimes.Add(semiPrime);
                    Console.WriteLine(string.Join(",", SemiPrimes));
                }
            }

        }



        static void Main(string[] args)
        {
            int N = 1;
            int M = 26;
            int[] P={ 1, 4, 16 };
            int[] Q={ 26, 10, 20  };
            Semiprime(M);
            Console.ReadKey();
        }
    }
}

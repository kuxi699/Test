using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
   public class Program
    {
        public static List<int> Semiprime(int M)
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


            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = 0; j < Lista.Count(); j++)
                {
                    int semiPrime = Lista[i] * Lista[j];
                    if (semiPrime > M)
                    {
                        break;
                    }

                    SemiPrimes.Add(semiPrime);
                  
                }
            }

            SemiPrimes = SemiPrimes.Distinct().ToList();
            SemiPrimes.Sort();
            Console.WriteLine(string.Join(",", SemiPrimes));
            return SemiPrimes;
        }

        public static void IleLiczb(int M, int[] P,int []Q)
        {
            List<int> Lista = new List<int>();
            List<int> L = new List<int>();
            List<int> Wynik = new List<int>();
            Lista = Semiprime(M);
            int Counter;

            for (int i = 0; i < P.Length; i++)
            {
                Counter = 0;

                if (P[i]<Q[i])
                {
                    for (int j = 0; j < Lista.Count; j++)
                    {
                        if (Lista[j] <= Q[i] & Lista[j] >= P[i])
                        {
                            L.Add(Lista[j]);
                            Counter= L.Count;                                                        
                        }
                       
                    }

                    L.Clear();
                   
                   
                }
                Wynik.Add(Counter);
               
            }
            Console.WriteLine(string.Join(",", Wynik));
        }

        static void Main(string[] args)
        {
         
            int M = 26;
            int[] P={ 1,4,16 };
            int[] Q={26,10,20  };
            IleLiczb(M, P, Q);
            Console.ReadKey();
        }
    }
}

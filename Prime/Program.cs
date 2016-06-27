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
            
            Console.Write(r);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoBusqueda_2023_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] A= new int[10];
            for(int i=0; i<A.Length; i++)
            {
                A[i]=random.Next(5,1000);                
            }

            for (int i=0; i<A.Length; i++)
            {
                Console.Write(" {0} ",A[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Qué número deseas buscar?");
            int x =int.Parse (Console.ReadLine());

            int b = Busqueda(A, x);
            if( b < 0)
            {
                Console.WriteLine("No se encontró el número");
            }
            else
            {
                Console.WriteLine("{0} se encuentra en la posición {1}",x,b);
            }
            Console.ReadLine();
        }

        static int Busqueda(int [] A, int x )
        {
            for(int i=0; i < A.Length; i++ )
            {
                if (A[i] == x  )
                {
                    return i;
                }

            }

            return -1;
        }
    }
}

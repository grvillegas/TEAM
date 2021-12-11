using System;
using System.IO;
using System.Linq;

namespace team
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int salida=0;
            
           
            n = Int32.Parse(Console.ReadLine());
            
            for (int i =0;i<n;i++) {
                  int[] a = (from string s in Console.ReadLine().Split(' ') select Convert.ToInt32(s)).ToArray();
                
                  int contador =0;

                  foreach (int votacion in a) {
                      if (votacion ==1) {
                          contador ++;
                      }
                  }
                  if (contador >=2) {
                      salida++;
                  }
            }
            Console.WriteLine(salida);
        }
    }
}

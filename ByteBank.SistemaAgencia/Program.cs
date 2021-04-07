using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();
            idades.Add(1);
            idades.Add(12);
            idades.Add(72);
            idades.Add(45);
            idades.Add(24);
            idades.Add(21);
            idades.Add(100);
            idades.Remove(15);
            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadLine();
        }
    }
}
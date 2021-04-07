using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensoes;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();
            idades.AdicionarVarios(1, 15, 34, 54, 42, 23, 80, 58);
            idades.Remove(15);
            foreach (int item in idades)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
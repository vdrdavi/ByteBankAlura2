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
            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);
            for (int i = 0; i < idades.Tamanho; i++)
            {
                Console.WriteLine(idades.GetItemNoindice(i));
            }

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");
            for (int i = 0; i < cursos.Tamanho; i++)
            {
                Console.WriteLine(cursos.GetItemNoindice(i));
            }

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));
            for (int i = 0; i < contas.Tamanho; i++)
            {
                Console.WriteLine(contas.GetItemNoindice(i));
            }

            Console.ReadLine();
        }
    }
}
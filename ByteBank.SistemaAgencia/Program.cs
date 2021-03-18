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
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            lista.Adicionar(new ContaCorrente(123, 2093847));
            lista.Adicionar(new ContaCorrente(232, 4892478));
            lista.Adicionar(new ContaCorrente(612, 3245233));

            Console.ReadLine();
        }
    }
}
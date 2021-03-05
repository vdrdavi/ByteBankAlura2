using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 6, 30);
            DateTime dataCorrete = DateTime.Now;
            TimeSpan diferencaDatas = dataFimPagamento - dataCorrete;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferencaDatas);
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}

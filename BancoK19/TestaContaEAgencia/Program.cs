using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaContaEAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Agencia a = new Agencia();
            Conta c = new Conta();

            a.numero = 178;
            c.saldo = 1000.0;

            c.agencia = a;

            Console.WriteLine($"Numero Agencia: {c.agencia.numero}");
            Console.WriteLine($"Saldo: {c.saldo}");
            Console.ReadLine();
        }
    }
}

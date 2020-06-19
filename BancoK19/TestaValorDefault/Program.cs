using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaValorDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            Console.WriteLine($"Saldo: {c.saldo}");
            Console.WriteLine($"Agencia: {c.agencia}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoK19
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta01 = new Conta();
            conta01.saldo = 1000.0;
            //conta01.limite = 500.0;
            conta01.numero = 1;

            Console.WriteLine($"- Dados da Conta");
            Console.WriteLine($"Saldo: {conta01.saldo}");
            Console.WriteLine($"Limite: {conta01.limite}");
            Console.WriteLine($"Numero: {conta01.numero}");

            Console.ReadLine();



        }
    }
}

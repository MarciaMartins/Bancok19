using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCartaoDeCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 11111;
            cdc1.dataDeValidade = "01/01/2021";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 22222;
            cdc2.dataDeValidade = "01/01/2022";

            cdc1.ImprimirCartaoDeCredito();
            cdc2.ImprimirCartaoDeCredito();

            Console.ReadLine();
        }
    }
}

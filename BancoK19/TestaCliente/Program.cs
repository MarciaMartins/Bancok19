using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new Cliente();
            cliente01.nome = "01 Nome Cliente";
            cliente01.codigo = 1;

            Cliente cliente02 = new Cliente();
            cliente02.nome = "02 Nome Cliente";
            cliente02.codigo = 2;

            cliente01.ImprimirCliente();
            cliente02.ImprimirCliente();

            Console.ReadLine();
        }
    }
}

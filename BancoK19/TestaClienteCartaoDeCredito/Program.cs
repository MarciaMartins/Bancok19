using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaClienteCartaoDeCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new Cliente();
            CartaoDeCredito cartaoDeCredito01 = new CartaoDeCredito();
            cliente01.nome = "01 Nome Cliente";
            cliente01.codigo = 1;

            cartaoDeCredito01.cliente = cliente01;
            cartaoDeCredito01.numero = 11111;
            cartaoDeCredito01.dataDeValidade = "01/01/2021";

            cliente01.ImprimirCliente();
            cartaoDeCredito01.ImprimirCartaoDeCredito();

            Console.WriteLine($"= Nome(Acesso atraves da Classe Cartao): {cartaoDeCredito01.cliente.nome}");
            

            Console.ReadLine();
        }
    }
}

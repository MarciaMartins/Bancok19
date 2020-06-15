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
            conta01.ImprimeDadosConta();

            

            CartaoCredito cartaoCredito01 = new CartaoCredito();
            Cliente cliente01 = new Cliente();
            cliente01.nome = "01 Nome do cliente";
            cliente01.codigo = 1;
            cliente01.ImprimeDadosCliente();

            Cliente cliente02 = new Cliente();
            cliente02.nome = "02 Nome do cliente";
            cliente02.codigo = 2;
            cliente02.ImprimeDadosCliente();
            
            CartaoCredito cdc1 = new CartaoCredito();
            cdc1.numero = 111111;
            cdc1.dataDeValidade = "01/01/2012";
            cdc1.ImprimeDadosCartaoCredito();

            CartaoCredito cdc2 = new CartaoCredito();
            cdc2.numero = 222222;
            cdc2.dataDeValidade = "01/01/2014";
            cdc2.ImprimeDadosCartaoCredito();

            Cliente clienteCartao = new Cliente();
            CartaoCredito cartaoCredito = new CartaoCredito();
            
            clienteCartao.nome = "Rafael Cosentino";
            cartaoCredito.numero = 111111;


            cartaoCredito.cliente = clienteCartao;
            Console.WriteLine(cartaoCredito.numero);
            Console.WriteLine(cartaoCredito.cliente.nome);

            Agencia agencia = new Agencia();
            Conta conta03 = new Conta();

            agencia.numero = 178;
            conta03.saldo = 1000.0;
            conta03.agencia = agencia;

            Console.WriteLine(conta03.agencia.numero);
            Console.WriteLine(conta03.saldo);




            Console.ReadLine();



        }
    }
}

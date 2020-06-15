using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoK19
{
    class CartaoCredito
    {
        public int numero;
        public string dataDeValidade;

        public Cliente cliente;

        public void ImprimeDadosCartaoCredito()
        {
            
            Console.WriteLine($"- Dados do Cartao de Credito");
            Console.WriteLine($" Numero: {this.numero}");
            Console.WriteLine($"Data de Validade: {this.dataDeValidade}");
            Console.WriteLine();
        }
    }
}

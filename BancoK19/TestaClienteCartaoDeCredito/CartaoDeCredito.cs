using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestaClienteCartaoDeCredito;

namespace TestaClienteCartaoDeCredito
{
    class CartaoDeCredito
    {
        public int numero;
        public string dataDeValidade;

        public Cliente cliente;
    

        public void ImprimirCartaoDeCredito()
        {
            Console.WriteLine($"-Numero: {numero}; " +
                $"-Data de Validade: {dataDeValidade}.");
        }
    }
}

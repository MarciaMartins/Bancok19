using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCartaoDeCredito
{
    class CartaoDeCredito
    {
        public int numero;
        public string dataDeValidade;
    

        public void ImprimirCartaoDeCredito()
        {
            Console.WriteLine($"-Numero: {numero}; " +
                $"-Data de Validade: {dataDeValidade}.");
        }
    }
}

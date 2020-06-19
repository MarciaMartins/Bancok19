using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaClienteCartaoDeCredito
{
    class Cliente
    {
        public string nome;
        public int codigo;

        public void ImprimirCliente()
        {
            Console.WriteLine($"- Nome: {nome}; " +
                $"- Codigo: {codigo}.");
        }
    }
}

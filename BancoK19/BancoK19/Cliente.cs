using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoK19
{
    class Cliente
    {
        public string nome;
        public int codigo;

        public void ImprimeDadosCliente()
        {
            Console.WriteLine($"- Dados do Cliente");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Codigo: {this.codigo}");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoK19
{
    class Conta
    {
        public double saldo;
        public double limite = 500;
        public int numero;

        public Agencia agencia;
    

        public void ImprimeDadosConta()
        {
            
            Console.WriteLine($"- Dados da Conta");
            Console.WriteLine($"Saldo: {this.saldo}");
            Console.WriteLine($"Limite: {this.limite}");
            Console.WriteLine($"Numero: {this.numero}");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar( string cpf) : base(2000, cpf) // Executa primeiro o construtor da classe base, passando cpf como argumento
        {
            Console.WriteLine("Criando Auxiliar");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2; // com base vai usar o GetBonificacao da classe Funcionario
        }
    }
}

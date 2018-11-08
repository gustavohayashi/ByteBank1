using ByteBank1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Funcionarios
{
    public class Diretor : Autenticavel
    {


        public Diretor( string cpf) : base(5000, cpf) // Executa primeiro o construtor da classe base, passando cpf como argumento
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

    
    }
}

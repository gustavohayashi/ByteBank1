using ByteBank1.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank1.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {

        public GerenteDeConta( string cpf) : base(4000, cpf) // Executa primeiro o construtor da classe base, passando cpf como argumento
        {
            Console.WriteLine("Criando Gerente De Conta");
        }


        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}

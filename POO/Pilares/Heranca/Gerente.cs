using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    public class Gerente : Funcionario
    {
        public void CalcularSalario()
        {
            SalarioBase = SalarioBase * 1.10f;
            Console.WriteLine($"O novo salario é de R${SalarioBase}");
            
        }
    }
}
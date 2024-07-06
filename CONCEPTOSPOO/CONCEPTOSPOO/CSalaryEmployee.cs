using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCEPTOSPOO
{
    //clase de empleado asalariado que hereda de la clase abstracta empleado.
    public class CSalaryEmployee : CEmployee
    {
        //su atributo salario
        public double Salary { get; set; }

        //lo que retornara el metodo abstracto
        public override double GetValueToPay()
        {
            return Salary;
        }

        //sobre escribimos e interpolamos 
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tvalue to pay.............: {$"{GetValueToPay():C2}", 18}";
        }
    }
}

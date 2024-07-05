using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCEPTOSPOO
{
    public class CSalaryEmployee : CEmployee
    {
        public double Salary { get; set; }

        public override double GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tvalue to pay.............: {$"{GetValueToPay():C2}", 18}";
        }
    }
}

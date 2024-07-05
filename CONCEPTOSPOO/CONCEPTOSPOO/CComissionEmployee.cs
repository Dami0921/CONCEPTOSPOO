using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CONCEPTOSPOO
{
    public class CComissionEmployee : CEmployee
    {
        public float ComissionPercentaje { get; set; }

        public double sales { get; set; }

        public override double GetValueToPay()
        {
            return sales * ComissionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tComission Percentaje.....: {$"{ComissionPercentaje:P2}", 18}" +
                   $"\n\tSales....................: {$"{sales:C2}", 18}" +
                   $"\n\tvalue to pay.............: {$"{GetValueToPay():C2}", 18}";
        }
    }
}

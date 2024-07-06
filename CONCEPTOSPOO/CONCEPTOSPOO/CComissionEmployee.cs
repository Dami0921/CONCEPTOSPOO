using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CONCEPTOSPOO
{
    //clase de empleado por comision que tambien hereda de la clase empleado.
    public class CComissionEmployee : CEmployee
    {
        //sus atributos de porcentaje de comision y ventas.
        public float ComissionPercentaje { get; set; }
        
        public double sales { get; set; }

        //lo que retorna el metodo getvalue 
        public override double GetValueToPay()
        {
            return sales * ComissionPercentaje;
        }
        //sobreescritura e interpolacion.
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tComission Percentaje.....: {$"{ComissionPercentaje:P2}", 18}" +
                   $"\n\tSales....................: {$"{sales:C2}", 18}" +
                   $"\n\tvalue to pay.............: {$"{GetValueToPay():C2}", 18}";
        }
    }
}

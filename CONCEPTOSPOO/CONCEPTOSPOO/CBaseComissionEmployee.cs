namespace CONCEPTOSPOO
{
    internal class CBaseComissionEmployee : CComissionEmployee
    {
        public double Base { get; set; }

        public override double GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tBase.....................: {$"{Base:C2}",18}";

        }
    }
}

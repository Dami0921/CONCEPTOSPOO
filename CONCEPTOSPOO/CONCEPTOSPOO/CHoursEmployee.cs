namespace CONCEPTOSPOO
{
    public class CHoursEmployee : CEmployee
    {
        public float Hours { get; set; }

        public double HoursValue { get; set; }

        public override double GetValueToPay()
        {
            return Hours * HoursValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tHoursValue...............: {$"{HoursValue}",18}" +
                   $"\n\tHours....................: {$"{Hours:N2}",18}" +
                   $"\n\tvalue to pay.............: {$"{GetValueToPay():C2}",18}";
        }
    }
}

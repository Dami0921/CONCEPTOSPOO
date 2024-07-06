namespace CONCEPTOSPOO
{
    public class CInvoice : IPay
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public float Quantity { get; set; }

        public double Price { get; set; }

        public double GetValueToPay()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return $"id: {ID}, Description: {Description} " +
                $"\n\tQuantity................: {$"{Quantity:N2}",18}" +
                $"\n\tPrice...................: {$"{Price:C2}",18}" +
                $"\n\tValue...................: {$"{GetValueToPay():C2}",18}";
        }
    }
}

namespace CONCEPTOSPOO
{
    public abstract class CEmployee
    {
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public cDate BirthDate { get; set; }

        public cDate HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract double GetValueToPay();

        public override string ToString()
        {
            return $"ID: {id}, First Name: {FirstName}, Last Name: {LastName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is Active: {IsActive}";
        }
    }
}

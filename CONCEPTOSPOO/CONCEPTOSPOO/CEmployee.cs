namespace CONCEPTOSPOO
{
    //creamos calse abstracta empleado
    public abstract class CEmployee
    {
        //sus propiedad en vez de campos.
        public int id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public cDate BirthDate { get; set; }

        public cDate HiringDate { get; set; }

        public bool IsActive { get; set; }

        //metodo abstracto.
        public abstract double GetValueToPay();

        //sobre escrbimos to.string.
        public override string ToString()
        {
            return $"ID: {id}, First Name: {FirstName}, Last Name: {LastName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is Active: {IsActive}";
        }
    }
}

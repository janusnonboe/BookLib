namespace BookLib
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return Id + " " + Name + " " + Salary;
        }
        public void validateName() 
        {
            if (Name == null) throw new ArgumentNullException("name cannot be empty" + Name);
        }
        public void validateSalery() 
        {
            if (Salary >= 0) throw new ArgumentException("salery musty be above 0" + Salary);
        }
        public void Validate() 
        { 
            validateSalery();
            validateName();
        }

    }
}

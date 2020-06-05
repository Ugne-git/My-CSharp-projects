namespace GradeBook
{
    public abstract class Book : NamedObject, IBook
    {
        //constructor
        protected Book(string name) : base(name)
        {
        }

        public virtual event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Stats GetStats()
        {
            throw new System.NotImplementedException();
        }
    }
}
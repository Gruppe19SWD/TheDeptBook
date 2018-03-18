namespace TheDeptBook.Model
{
     public class Loan
    {
        public string Description { get ; private set; }
        public double Value { get; private set; }

        public Loan(string d, double v)
        {
            Description = d;
            Value = v;
        }
    }
}

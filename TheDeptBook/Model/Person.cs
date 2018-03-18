using System.Collections.Generic;
using System.Reflection.Emit;

namespace TheDeptBook.Model
{
    public class Person
    {
        public string Name { get; private set; }
        public List<Loan> Loans { get; private set; }
        public double Total { get; private set; }

        public Person(string n, List<Loan> l)
        {
            Name = n;
            Loans = l;
            Total = CalculateTotal();
        }

        
        public double CalculateTotal()
        {
            double total = 0;
            foreach (var dept in Loans)
            {
                total += dept.Value;
            }

            return total;
        }
    }
}

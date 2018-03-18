using System.Collections.Generic;

namespace TheDeptBook.Model
{
    public class DeptModel
    {
        //public List<Person> persons = new List<Person>();
        private List<Loan> loan1 = new List<Loan>();
        private List<Loan> loan2 = new List<Loan>();
        private List<Loan> loan3 = new List<Loan>();

        public Person SelectedPerson { get; set; }

        public string NameOfSelectedPerson { get; set; }
        public List<Person> Persons { get; private set; } = new List<Person>();

        public DeptModel()
        {
            //Instantiere data til visning i modellen
            loan1.Add(new Loan("Kaffe", -9));

            loan1.Add(new Loan("Kage", -12));
            loan1.Add(new Loan("Pizza", +35));

            loan2.Add(new Loan("Flybillet til Maldiverne", -4979));
            loan2.Add(new Loan("Dykkertur", -1989));

            loan3.Add(new Loan("Kontigent", -75));

            Persons.Add(new Person("Anders", loan1));
            Persons.Add(new Person("Morten", loan2));
            Persons.Add(new Person("Udbetaling Danmark", loan3));
            SelectedPerson = Persons[0];
            NameOfSelectedPerson = SelectedPerson.Name;

        }

        

        
    }
}

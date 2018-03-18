using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using JetBrains.Annotations;
using TheDeptBook.Model;
using TheDeptBook.Properties;

namespace TheDeptBook.ViewModel
{
    public class DeptViewModel : BaseViewModel
    {
        // DeptViewModel arver fra BaseViewModel grundet en ide til videre implementering, hvor de forskellige views kører på forskellige viewmodels.
        // Her ville det view der vises være bestemt af den property set her under
        // public BaseViewModel ViewModel { get; set; }



        public DeptModel DM;

        public DeptViewModel(DeptModel _DM)
        {
            DM = _DM;
        }

        // Henter listerne, der skal vises fra deptmodellen
        public List<Person> PersonList => DM.Persons;
        public List<Loan> SelectedPersonLoan => DM.SelectedPerson.Loans;


        // Sætter SelectedPerson i modellen og laver onPropertyChanged på relevante properties
        public Person SelectedPerson
        {
            get
            {
                return DM.SelectedPerson;
            }
            set
            {
                if (DM.SelectedPerson != value && value != null)
                {

                    DM.SelectedPerson = value;
                    DM.NameOfSelectedPerson = value.Name;
                    OnPropertyChanged("NameOfSelectedPerson");
                    // Ny valgt person (SelectedPerson) starter også en ny onPropertyChanged på lånet, der vises i view 2 (DetailsWindow)
                    OnPropertyChanged("SelectedPersonLoan");
                }
            }
        }

        // Ændrer navnet ved ny SelectedPerson og kalder onPropertyChanged
        public string NameOfSelectedPerson
        {
            get
            {
                if (SelectedPerson == null)
                {
                    return "No selected person";
                }
                return DM.NameOfSelectedPerson;

            }
            set
            {
                DM.NameOfSelectedPerson = DM.SelectedPerson.Name;
                OnPropertyChanged();
            }

        }

    }
}

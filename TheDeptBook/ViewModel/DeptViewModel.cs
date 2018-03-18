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
        //at den arver fra BaseViewModel er grundet en ideer til videre implementation hvor de forskellige views kører på forskellige viewmodels
        public BaseViewModel ViewModel { get; set; }
        public DeptModel DM;

        public DeptViewModel(DeptModel _DM)
        {
            DM = _DM;
        }
        public List<Person> PersonList => DM.Persons;
        public List<Loan> SelectedPersonLoan => DM.SelectedPerson.Loans;





        #region Commands

        

        #endregion


        //sætter selectedPerson i modellen og laver onPropertyChanged på relevante properties
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
                    OnPropertyChanged("SelectedPersonLoan");
                }
            }
        }
        
        //ændrer navnet ved ny selectedPerson og kalder onPropertyChanged
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

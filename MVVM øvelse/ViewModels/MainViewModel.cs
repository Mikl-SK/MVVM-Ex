using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVVM_øvelse.ViewModels
{
    public class MainViewModel
    {
        public Views.Window1 MainWindow { get; set; }

        public Models.DataManager dataManager { get; set; }

        public MainViewModel(Views.Window1 mainWindow)
        {
            dataManager = new Models.DataManager(this);
            MainWindow = mainWindow;
        }

        public string GetFirstName()
        {
            return dataManager.ImportantPerson.FirstName;
        }

        internal void IsChanged()
        {
            MainWindow.IsChanged() ;
        }

        public string GetLastName()
        {
            return dataManager.ImportantPerson.LastName;
        }
        public string GetFullName()
        {
            return dataManager.ImportantPerson.FullName;
        }

        internal void SavePerson(string firstName, string lastName)
        {
            dataManager.ImportantPerson.FirstName = firstName;
            dataManager.ImportantPerson.LastName = lastName;
        }
    }
}

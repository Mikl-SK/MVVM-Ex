using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_øvelse.Models
{
    public class DataManager
    {
        public Person ImportantPerson { get; set; }

        public ViewModels.MainViewModel Mvm { get; set; }
        public DataManager(ViewModels.MainViewModel mainViewModel)
        {
            ImportantPerson = new Person(this) { FirstName = "Anders", LastName = "And" };
            Mvm = mainViewModel;
        }

        public void IsChanged()
        {
            Mvm.IsChanged();
        }
    }
}

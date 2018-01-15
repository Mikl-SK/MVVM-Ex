using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_øvelse.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName { get { return firstName; } set { firstName = value; DataManager.IsChanged(); } }
        public string LastName { get { return lastName; } set { lastName = value; DataManager.IsChanged(); } }
        public string FullName { get
            {
                return FirstName + " " + LastName;
            }
        }
        public DataManager DataManager { get; set; }

        public Person(DataManager dataManager)
        {
            DataManager = dataManager;
        }
    }
}

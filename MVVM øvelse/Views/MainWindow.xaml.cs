using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM_øvelse.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ViewModels.MainViewModel mainViewModel { get; set; }
        public Window1()
        {
            InitializeComponent();

            mainViewModel = new ViewModels.MainViewModel(this);

            SetNames();
        }

        internal void IsChanged()
        {
            SetNames();
        }

        private void SetNames()
        {
            FirstName.Text = mainViewModel.GetFirstName();
            LastName.Text = mainViewModel.GetLastName();
            FullName.Text = mainViewModel.GetFullName();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.SavePerson(FirstName.Text, LastName.Text);
            SetNames();
        }

        private void Cheat_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.SavePerson("hest", "bob");
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vet.Views;

namespace Vet.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoServices_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new ServicesPage());
        }

        private void GoCabs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new CabsPage());
        }

        private void GoMedcards_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new MedcardsPage());
        }

        private void GoEmployees_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new EmployeesPage());
        }

        private void GoClients_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new ClientsPage());
        }

        private void btnCheques_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new ChequesPage());
        }
    }
}

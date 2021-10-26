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
using Vet.DataBase;
using Vet.Views;

namespace Vet.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public static User authUser;
        public EmployeesPage()
        {
            InitializeComponent();
            EmployeesGrid.ItemsSource = man.Employee.ToList();
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new MainPage());
        }

        class EmployeesTable
        {
            public EmployeesTable(int IDEmployee,string Surname,string Name,string FatherName,string Phone, string PassSerial, string PassNumber, string Address)
            {
                this.IDEmployee = IDEmployee;
                this.Surname = Surname;
                this.Name = Name;
                this.FatherName = FatherName;
                this.Phone = Phone;
                this.PassSerial = PassSerial;
                this.PassNumber = PassNumber;
                this.Address = Address;
            }
            public int IDEmployee { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string FatherName { get; set; }
            public string Phone { get; set; }
            public string PassSerial { get; set; }
            public string PassNumber { get; set; }
            public string Address { get; set; }
        }
        public menEntities man = new menEntities();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            switch (AuthWindow.authUser.IDRole)
            {
                case 1: EmployeesGrid.IsReadOnly = false; break;
                case 2: EmployeesGrid.IsReadOnly = true; break;
                case 3: EmployeesGrid.IsReadOnly = false; break;
                default: break;
            }
        }
    }
}

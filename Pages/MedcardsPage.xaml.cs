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
namespace Vet.Pages
{
    /// <summary>
    /// Логика взаимодействия для MedcardsPage.xaml
    /// </summary>
    public partial class MedcardsPage : Page
    {
        public MedcardsPage()
        {
            InitializeComponent();
            MedcardsGrid.ItemsSource = man.Medcard.ToList();
        }
        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new MainPage());
        }

        class MedcardsTable
        {
            public MedcardsTable(int IDMedcard, int IDPatient, string CurrentState, string History)
            {
                this.IDMedcard = IDMedcard;
                this.IDPatient = IDPatient;
                this.CurrentState = CurrentState;
                this.History = History;
            }
            public int IDMedcard { get; set; }
            public int IDPatient { get; set; }
            public string CurrentState { get; set; }
            public string History { get; set; }

        }

        public menEntities man = new menEntities();
    }
}

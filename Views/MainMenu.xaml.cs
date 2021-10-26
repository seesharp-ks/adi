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
using Vet.Pages;
using Vet.Views;
using Vet.DataBase;
namespace Vet.Views
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public static menEntities man = new menEntities();
        public User userUpdate = AuthWindow.authUser;
        public MainMenu()
        {
            InitializeComponent();
            frmLoader.Navigate(new MainPage());
            frmLoader2.Navigate(new SchedulePage());
            tbkFIO.Text = userUpdate.Employee.Surname + " " + userUpdate.Employee.Name + " " + userUpdate.Employee.FatherName;
            tbkRank.Text = userUpdate.Role.RoleName;
            tbxPhone.Text = userUpdate.Employee.Phone;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, t) => { lbCurrentDateTime.Content = DateTime.Now.ToString(); };
            timer.Start();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            AuthWindow.authUser = null;
            AuthWindow aw = new AuthWindow();
            aw.Show();
        }

        private void btnSavePhone_Click(object sender, RoutedEventArgs e)
        {
            if (tbxPhone == null)
            {
                MessageBox.Show("Заполните поле 'Телефон'", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var res = MessageBox.Show("Вы хотите сохранить изменения?", "да", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                userUpdate.Employee.Phone = tbxPhone.Text;
                man.SaveChanges();
            }
        }
    }
}

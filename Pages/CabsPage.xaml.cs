using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Vet.Views;
using Vet.DataBase;
using System;
using System.Collections.Generic;

namespace Vet.Pages
{
    /// <summary>
    /// Логика взаимодействия для CabsPage.xaml
    /// </summary>
    public partial class CabsPage : Page
    {
        public menEntities man = new menEntities();
        public CabsPage()
        {
            InitializeComponent();
            bindList();
        }

        private void bindList()
        {
            List<Label> list = new List<Label>();
            Label a = new Label(), b = new Label();
            a.Content = "test";
            b.Content = "test";
            list.Add(a);
            list.Add(b);
            CabsList.ItemsSource = list; //https://www.youtube.com/watch?v=1lU-4VQpdRg
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            ns.Navigate(new MainPage());
        }

        private void btnCab1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

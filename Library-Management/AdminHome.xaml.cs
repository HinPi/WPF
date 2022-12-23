using System.Windows;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminHome : Window
    {
        public AdminHome()
        {
            InitializeComponent();
            AdminBooks adminBooks = new AdminBooks();
            adminStackPanel.Children.Clear();
            adminStackPanel.Children.Add(adminBooks);
        }
        private void BtnBooks_Click(object sender, RoutedEventArgs e)
        {

            AdminBooks adminBooks = new AdminBooks();
            adminStackPanel.Children.Clear();
            adminStackPanel.Children.Add(adminBooks);
        }
        private void BtnUsers_Click(object sender, RoutedEventArgs e)
        {
            AdminUsers adminUsers = new AdminUsers();
            adminStackPanel.Children.Clear();
            adminStackPanel.Children.Add(adminUsers);
        }
        private void BtnRequests_Click(object sender, RoutedEventArgs e)
        {
            AdminRequests adminRequests = new AdminRequests();
            adminStackPanel.Children.Clear();
            adminStackPanel.Children.Add(adminRequests);

        }
        private void BtnAccepted_Click(object sender, RoutedEventArgs e)
        {
            AdminAccepted adminAccepted = new AdminAccepted();
            adminStackPanel.Children.Clear();
            adminStackPanel.Children.Add(adminAccepted);

        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnReturn_Click(object sender, RoutedEventArgs e)
        {
            AdminReturn adminReturn = new AdminReturn();
            adminStackPanel.Children.Clear();
            adminStackPanel.Children.Add(adminReturn);
        }
    }
}

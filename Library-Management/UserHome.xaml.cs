using System.Windows;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for UserHome.xaml
    /// </summary>
    public partial class UserHome : Window
    {
        public UserHome()
        {
            InitializeComponent();
            UserBorrow userBorrow = new UserBorrow();
            userStackPanel.Children.Clear();
            userStackPanel.Children.Add(userBorrow);
        }
        private void BtnBorrow_Click(object sender, RoutedEventArgs e)
        {
            UserBorrow userBorrow = new UserBorrow();
            userStackPanel.Children.Clear();
            userStackPanel.Children.Add(userBorrow);
        }
        //SHOW BOOK REQUEST AND BOOK RECIEVED MENU
        private void BtnTransaction_Click(object sender, RoutedEventArgs e)
        {
            UserTransaction userTransaction = new UserTransaction();
            userStackPanel.Children.Clear();
            userStackPanel.Children.Add(userTransaction);
        }
        //LOGOUT USER HOME
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

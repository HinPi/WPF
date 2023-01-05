using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminHomeReDesign.xaml
    /// </summary>
    public partial class AdminHomeReDesign : Window
    {
        public AdminHomeReDesign()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // set tooptips hiden
            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_books.Visibility = Visibility.Collapsed;
                tt_users.Visibility = Visibility.Collapsed;
                tt_accepted.Visibility = Visibility.Collapsed;
                tt_history.Visibility = Visibility.Collapsed;
                tt_requests.Visibility = Visibility.Collapsed;

            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_books.Visibility = Visibility.Visible;
                tt_users.Visibility = Visibility.Visible;
                tt_accepted.Visibility = Visibility.Visible;
                tt_history.Visibility = Visibility.Visible;
                tt_requests.Visibility = Visibility.Visible;
            }

        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewItem lbi = ((sender as ListView).SelectedItem as ListViewItem);
            //  var item = e.OriginalSource as ListViewItem;
            var namepage = lbi.Name;
            tbTitle.Text = namepage;
            frContent.Navigate(new System.Uri(namepage + ".xaml", System.UriKind.Relative));
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }
    }
}

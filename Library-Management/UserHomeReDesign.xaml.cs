using System.Windows;
using System.Windows.Controls;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for UserHomeReDesign.xaml
    /// </summary>
    public partial class UserHomeReDesign : Window
    {
        public UserHomeReDesign()
        {
            InitializeComponent();
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewItem lbi = ((sender as ListView).SelectedItem as ListViewItem);
            //  var item = e.OriginalSource as ListViewItem;
            var namepage = lbi.Name;
            tbTitle.Text = namepage;
            frContent.Navigate(new System.Uri(namepage + ".xaml", System.UriKind.Relative));
        }

        private void StackPanel_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }
    }
}

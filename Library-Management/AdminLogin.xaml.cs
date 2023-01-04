using BLL;
using System;
using System.Windows;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if ((tbAdminEmail.Text != string.Empty || tbAdminPass.Password != string.Empty) || (tbAdminEmail.Text != string.Empty && tbAdminPass.Password != string.Empty))
            {
                try
                {
                    AdminBL adminBl = new AdminBL();
                    bool isDone = adminBl.AdminLoginBL(tbAdminEmail.Text, tbAdminPass.Password);
                    if (isDone)
                    {
                        alertAdmin.Content = "";
                        MessageBox.Show("Logged in successfully...");
                        AdminHome adminHome = new AdminHome();
                        adminHome.Show();
                        this.Close();
                        tbAdminEmail.Clear();
                        tbAdminPass.Clear();
                    }
                    else
                    {

                        alertAdmin.Content = "Invalid email id or password...";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                alertAdmin.Content = "Enter the fields properly...";
            }
        }
    }
}

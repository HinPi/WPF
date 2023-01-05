using BLL;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public static int userId;

        public AdminLogin()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedRole = (ComboBoxItem)cbRole.SelectedItem;
            //MessageBox.Show(selectedCar.Content.ToString());

            if (selectedRole.Content.ToString() == "Admin")
            {
                if ((tbAdminEmail.Text != string.Empty || tbAdminPass.Password.ToString() != string.Empty) || (tbAdminEmail.Text != string.Empty && tbAdminPass.Password.ToString() != string.Empty))
                {
                    try
                    {
                        AdminBL adminBl = new AdminBL();
                        bool isDone = adminBl.AdminLoginBL(tbAdminEmail.Text, tbAdminPass.Password.ToString());
                        if (isDone)
                        {
                            alertAdmin.Content = "";
                            MessageBox.Show("Logged in successfully...");
                            AdminHomeReDesign adminHome = new AdminHomeReDesign();
                            adminHome.Show();
                            tbAdminEmail.Clear();
                            tbAdminPass.Clear();
                            this.Close();
                        }
                        else
                        {

                            alertAdmin.Content = "Invalid email id or password...";
                            tbAdminEmail.Clear();
                            tbAdminPass.Clear();
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
            else if (selectedRole.Content.ToString() == "User")
            {
                if ((tbAdminEmail.Text != string.Empty || tbAdminPass.Password.ToString() != string.Empty) || (tbAdminEmail.Text != string.Empty && tbAdminPass.Password.ToString() != string.Empty))
                {
                    try
                    {
                        UserBL userBL = new UserBL();
                        int isDone = userBL.UserLoginBL(tbAdminEmail.Text, tbAdminPass.Password.ToString());
                        if (isDone != 0)
                        {
                            userId = isDone;
                            MessageBox.Show("Logged in successfully...");
                            UserHome userHome = new UserHome();
                            userHome.Show();
                            tbAdminEmail.Clear();
                            tbAdminPass.Clear();
                        }
                        else
                        {
                            alertAdmin.Content = "Invalid email id or password...";
                            tbAdminEmail.Clear();
                            tbAdminPass.Clear();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Some unknown exception is occured!!!, Try again..");
                    }
                }
                else
                {
                    alertAdmin.Content = "Enter the fields properly...";
                }

            }

        }
    }
}

using BLL;
using System;
using System.Windows;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminUpdateUser.xaml
    /// </summary>
    public partial class AdminUpdateUser : Window
    {
        public int userId;
        public AdminUpdateUser()
        {
            InitializeComponent();
            userId = AdminUsers.updateUser.UserId;
            tbUName.Text = AdminUsers.updateUser.UserName;
            tbUAdNo.Text = AdminUsers.updateUser.UserAdNo.ToString();
            tbUEmail.Text = AdminUsers.updateUser.UserEmail;
            tbUPass.Text = AdminUsers.updateUser.UserPass;
        }
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (tbUName.Text != string.Empty && tbUAdNo.Text != string.Empty && tbUEmail.Text != string.Empty && tbUPass.Text != string.Empty)
            {
                try
                {
                    UserBL userBL = new UserBL();
                    string isDone = userBL.UpdateUserBL(userId, tbUName.Text, int.Parse(tbUAdNo.Text), tbUEmail.Text, tbUPass.Text);
                    if (isDone == "true")
                    {
                        MessageBox.Show("User updated successfuly..");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(isDone + " Try later..");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Admission number!!!,\nIt should not be a string, Try again..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly!!!, Every field is required..");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            tbUAdNo.Text = rand.Next().ToString();
        }
    }
}

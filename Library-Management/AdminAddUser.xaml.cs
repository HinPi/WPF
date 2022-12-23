using BLL;
using System;
using System.Windows;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminAddUser.xaml
    /// </summary>
    public partial class AdminAddUser : Window
    {
        public AdminAddUser()
        {
            InitializeComponent();
        }
        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (tbUName.Text != string.Empty && tbUAdNo.Text != string.Empty && tbUEmail.Text != string.Empty && tbUPass.Text != string.Empty)
            {
                try
                {
                    UserBL userBL = new UserBL();
                    string isDone = userBL.AddUserBL(tbUName.Text, int.Parse(tbUAdNo.Text), tbUEmail.Text, tbUPass.Text);
                    if (isDone == "true")
                    {
                        MessageBox.Show("User added successfuly..");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(isDone + "Try again..");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Admission number!!!,\nIt should not be a string, Try again..");
                }
                catch (Exception)
                {
                    MessageBox.Show("Some unknown exception is occured!!!, Try again..");
                }
            }
            else
            {
                MessageBox.Show("Enter the fields properly!!!, Every field is required..");
            }

        }
    }
}

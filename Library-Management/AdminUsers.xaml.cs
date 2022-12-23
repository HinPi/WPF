using BLL;
using DTO;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminUsers.xaml
    /// </summary>
    public partial class AdminUsers : UserControl
    {
        public static User updateUser = new User();
        public AdminUsers()
        {
            InitializeComponent();
            InitializeAdminUsers();
        }
        public void InitializeAdminUsers()
        {
            try
            {
                UserBL userBl = new UserBL();
                DataSet ds = userBl.GetAllUsersBL();
                ObservableCollection<User> lst = new ObservableCollection<User>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(new User
                    {
                        UserName = Convert.ToString(dr["UserName"]),
                        UserId = Convert.ToInt32(dr["UserId"]),
                        UserEmail = Convert.ToString(dr["UserEmail"]),
                        UserPass = Convert.ToString(dr["UserPass"]),
                        UserAdNo = Convert.ToInt32(dr["UserAdNo"]),

                    });
                }
                dgUsers.ItemsSource = lst;
            }
            catch (Exception)
            {
                MessageBox.Show("Some unknown exception is occured!!!, Try again..");
            }
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = dgUsers.SelectedItem as User;
                if (user != null)
                {
                    updateUser = user;
                    AdminUpdateUser adminUpdateUser = new AdminUpdateUser();
                    adminUpdateUser.Show();
                }
                else
                {
                    MessageBox.Show("Select a user to update...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some unknown exception is occured!!!, Try again..");
            }
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = dgUsers.SelectedItem as User;
                if (user != null)
                {
                    UserBL userBL = new UserBL();
                    bool isDone = userBL.DeleteUserBL(user.UserId);
                    if (isDone == true)
                    {
                        MessageBox.Show("User deleted successfully...");
                        InitializeAdminUsers();
                    }
                    else
                    {
                        MessageBox.Show("Server is in maintainance try again later...");
                    }
                }
                else
                {
                    MessageBox.Show("Select a user to delete...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some unknown exception is occured!!!, Try again..");
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AdminAddUser adminAddUser = new AdminAddUser();
            adminAddUser.Show();
        }
    }
}

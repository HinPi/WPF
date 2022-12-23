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
    /// Interaction logic for AdminAccepted.xaml
    /// </summary>
    public partial class AdminAccepted : UserControl
    {
        public AdminAccepted()
        {
            InitializeComponent();
            InitializeAdminAccepted();
        }
        public void InitializeAdminAccepted()
        {
            try
            {
                UserRecieveBL userRecieve = new UserRecieveBL();
                DataSet ds = userRecieve.GetAllRecieveDAL();

                ObservableCollection<AcceptedBook> lst = new ObservableCollection<AcceptedBook>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(new AcceptedBook
                    {
                        BookName = Convert.ToString(dr["BookName"]),
                        BookId = Convert.ToInt32(dr["BookId"]),
                        UserId = Convert.ToInt32(dr["UserId"]),
                        UserName = Convert.ToString(dr["UserName"]),
                        DateRecieved = Convert.ToString(Convert.ToDateTime(dr["DateRecieved"]).ToShortDateString()),
                    });
                }
                dgAccepted.ItemsSource = lst;
            }
            catch (Exception)
            {
                MessageBox.Show("Some unknown exception is occured!!!, Try again..");
            }
        }
        //DELETE THE RECIEVED BOOK =>PL
        /*private void btnTake_Click(object sender, RoutedEventArgs e)
        {
            AcceptedBook accept = dgAccepted.SelectedItem as AcceptedBook;
            if (accept!=null)
            {
                UserRecieveBL userRecieveBL = new UserRecieveBL();
                bool isDone1 = userRecieveBL.DeleteRecieveBL(accept.BookId, accept.UserId);
                BookBL bookBL = new BookBL();
                bool isDone2 = bookBL.IncBookCopyBL(accept.BookId);
                if (isDone1 == true && isDone2 == true)
                {
                    MessageBox.Show("Book taken back successfully...");
                    InitializeAdminAccepted();
                }
                else
                {
                    MessageBox.Show("Try again...");
                }
            }
            else
            {
                MessageBox.Show("Select a book properly...");
            }

        }*/
    }
}

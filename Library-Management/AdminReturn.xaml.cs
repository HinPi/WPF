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
    /// Interaction logic for AdminReturn.xaml
    /// </summary>
    public partial class AdminReturn : UserControl
    {
        public AdminReturn()
        {
            InitializeComponent();
            InitializeAdminReturn();
        }
        public void InitializeAdminReturn()
        {
            try
            {
                UserReturnBL userReturn = new UserReturnBL();
                DataSet ds = userReturn.GetAllReturnBL();

                ObservableCollection<ReturnedBook> lst = new ObservableCollection<ReturnedBook>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(new ReturnedBook
                    {
                        BookName = Convert.ToString(dr["BookName"]),
                        BookId = Convert.ToInt32(dr["BookId"]),
                        UserId = Convert.ToInt32(dr["UserId"]),
                        UserName = Convert.ToString(dr["UserName"]),
                        DateReturned = Convert.ToString(Convert.ToDateTime(dr["DateReturned"]).ToShortDateString()),
                    });
                }
                dgReturn.ItemsSource = lst;
            }
            catch (Exception)
            {
                MessageBox.Show("Some unknown exception is occured!!!, Try again..");
            }
        }
        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ReturnedBook returned = dgReturn.SelectedItem as ReturnedBook;
                if (returned != null)
                {
                    UserReturnBL userReturnBL = new UserReturnBL();
                    bool isDone1 = userReturnBL.DeleteReturnBL(returned.BookId, returned.UserId);
                    BookBL bookBL = new BookBL();
                    bool isDone2 = bookBL.IncBookCopyBL(returned.BookId);
                    if (isDone1 == true && isDone2 == true)
                    {
                        MessageBox.Show("Book taken back successfully...");
                        InitializeAdminReturn();
                    }
                    else
                    {
                        MessageBox.Show("Try again...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

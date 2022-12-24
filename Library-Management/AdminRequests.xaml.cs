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
    /// Interaction logic for AdminRequests.xaml
    /// </summary>
    public partial class AdminRequests : UserControl
    {
        public AdminRequests()
        {
            InitializeComponent();
            InitializeRequests();
        }
        public void InitializeRequests()
        {
            try
            {
                UserRequestBL userRequestBL = new UserRequestBL();
                DataSet ds = userRequestBL.GetAllRequestBL();

                ObservableCollection<RequestedBook> lst = new ObservableCollection<RequestedBook>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(new RequestedBook
                    {
                        BookName = Convert.ToString(dr["BookName"]),
                        BookId = Convert.ToInt32(dr["BookId"]),
                        UserId = Convert.ToInt32(dr["UserId"]),
                        UserName = Convert.ToString(dr["UserName"]),
                        DateRequested = Convert.ToString(Convert.ToDateTime(dr["DateRequested"]).ToShortDateString()),


                    });
                }
                dgRequests.ItemsSource = lst;
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
                RequestedBook request = dgRequests.SelectedItem as RequestedBook;
                if (request != null)
                {
                    UserRecieveBL userRecieveBL = new UserRecieveBL();
                    bool isDone1 = userRecieveBL.AddRecieveBL(request.BookId, request.BookName, request.UserId, request.UserName);
                    UserRequestBL userRequest = new UserRequestBL();
                    bool isDone2 = userRequest.DeleteRequestBL(request.BookId, request.UserId);
                    if (isDone1 == true && isDone2 == true)
                    {
                        MessageBox.Show("Accepted request successfully...");
                        InitializeRequests();
                    }
                    else
                    {
                        MessageBox.Show("Try again latter...");
                    }
                }
                else
                {
                    MessageBox.Show("Select book properly...");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void BtnReject_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RequestedBook request = dgRequests.SelectedItem as RequestedBook;
                if (request != null)
                {
                    BookBL bookBL = new BookBL();
                    bool isDone1 = bookBL.IncBookCopyBL(request.BookId);
                    UserRequestBL userRequest = new UserRequestBL();
                    bool isDone2 = userRequest.DeleteRequestBL(request.BookId, request.UserId);
                    if (isDone1 == true && isDone2 == true)
                    {
                        MessageBox.Show("Rejected request successfully...");
                        InitializeRequests();
                    }
                    else
                    {
                        MessageBox.Show("Try again latter...");
                    }
                }
                else
                {
                    MessageBox.Show("Select book properly...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Some unknown exception is occured!!!, Try again..");
            }

        }
    }
}

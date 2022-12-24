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
    /// Interaction logic for UserBorrow.xaml
    /// </summary>
    public partial class UserBorrow : UserControl
    {
        public int userId;
        public UserBorrow()
        {
            InitializeComponent();
            InitializeUserBorrow();
        }

        public void InitializeUserBorrow()
        {
            try
            {
                BookBL bookBl = new BookBL();
                DataSet ds = bookBl.GetAllBooksBL();
                userId = UserLogin.userId;
                ObservableCollection<Book> lst = new ObservableCollection<Book>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(new Book
                    {
                        BookName = Convert.ToString(dr["BookName"]),
                        BookId = Convert.ToInt32(dr["BookId"]),
                        BookAuthor = Convert.ToString(dr["BookAuthor"]),
                        BookISBN = Convert.ToString(dr["BookISBN"]),
                        BookCopies = Convert.ToInt32(dr["BookCopies"]),
                        BookPrice = Convert.ToInt32(dr["BookPrice"]),
                    });
                }
                dgBorrow.ItemsSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BtnRequest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book book = dgBorrow.SelectedItem as Book;
                if (book != null)
                {
                    if (book.BookCopies == 0)
                    {
                        MessageBox.Show("Book is empty...");
                    }
                    else
                    {
                        int BookCopy = book.BookCopies - 1;
                        BookBL bookBL = new BookBL();
                        UserRequestBL userRequestBL = new UserRequestBL();
                        string isDone1 = bookBL.UpdateBookBL(book.BookId, book.BookName, book.BookAuthor, book.BookISBN, book.BookPrice, BookCopy);
                        bool isDone2 = userRequestBL.AddRequestBL(book.BookId, book.BookName, userId);
                        if (isDone1 == "true" && isDone2 == true)
                        {
                            MessageBox.Show("Requested successfully..");
                            InitializeUserBorrow();
                        }
                        else
                        {
                            MessageBox.Show("Try again..");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Select a book to request...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

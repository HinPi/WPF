using BLL;
using System;
using System.Windows;

namespace Library_Management
{
    /// <summary>
    /// Interaction logic for AdminUpdateBook.xaml
    /// </summary>
    public partial class AdminUpdateBook : Window
    {
        public int bookId;
        public AdminUpdateBook()
        {
            InitializeComponent();
            this.bookId = AdminBooks.updateBook.BookId;
            tbBName.Text = AdminBooks.updateBook.BookName;
            tbBAuthor.Text = AdminBooks.updateBook.BookAuthor;
            tbBISBN.Text = AdminBooks.updateBook.BookISBN;
            tbBPrice.Text = AdminBooks.updateBook.BookPrice.ToString();
            tbBCopy.Text = AdminBooks.updateBook.BookCopies.ToString();
        }
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (tbBName.Text != string.Empty && tbBAuthor.Text != string.Empty && tbBISBN.Text != string.Empty && tbBPrice.Text != string.Empty &&
                tbBCopy.Text != string.Empty
                )
            {
                try
                {
                    BookBL bookBL = new BookBL();
                    string isDone = bookBL.UpdateBookBL(this.bookId, tbBName.Text, tbBAuthor.Text, tbBISBN.Text, double.Parse(tbBPrice.Text), int.Parse(tbBCopy.Text));
                    if (isDone == "true")
                    {
                        MessageBox.Show("Book updated successfuly..");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(isDone + " Try later..");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Book price or Book copy!!!,\nThey should not be a string, Try again..");
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

// File: LibraryManagementSystem.xaml.cs

using System.Collections.Generic;
using System.Windows;

namespace LibraryManagementSystem
{
    public partial class MainWindow : Window
    {
        private List<Book> books = new List<Book>();

        public MainWindow()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            books.Add(new Book { Title = "1984", Author = "George Orwell" });
            books.Add(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" });
            booksList.ItemsSource = books;
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            string title = bookTitle.Text;
            string author = bookAuthor.Text;

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
            {
                books.Add(new Book { Title = title, Author = author });
                booksList.Items.Refresh();
                MessageBox.Show("Book added successfully!");
            }
            else
            {
                MessageBox.Show("Both Title and Author are required.");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}

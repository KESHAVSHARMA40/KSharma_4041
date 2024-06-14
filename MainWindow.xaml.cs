using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W5CodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // declare the context class object
        BooksContext db = new BooksContext();  
        public MainWindow()
        {
          InitializeComponent();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            /*var books = db.Books.ToList();
            grdBooks.ItemsSource = books;
            */
            // or we can use this

            grdBooks.ItemsSource = db.Books.ToList();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.Price = decimal.Parse(txtPrice.Text);
            book.Quantity = 5;
            db.Books.Add(book);

            db.SaveChanges();

            grdBooks.ItemsSource = db.Books.ToList();
            MessageBox.Show("New Book added");

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var book = db.Books.Find(id); //week6

            if (book != null)
            {
                book.Title = txtTitle.Text;
                book.Price = decimal.Parse(txtPrice.Text);
                book.Quantity = 10;

                grdBooks.ItemsSource = db.Books.ToList();
                db.SaveChanges();
                MessageBox.Show("Book Updated");
            }
            else
            {

                MessageBox.Show("Invalid Id Please try again");
                grdBooks.ItemsSource = db.Books.ToList();
            }
            }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            int id = int.Parse(txtId.Text);
            var book = db.Books.Find(id); //week6

            if (book != null)
            {
               db.Books.Remove(book);

                grdBooks.ItemsSource = db.Books.ToList();
                db.SaveChanges();
                MessageBox.Show("Book Deleted");
            }
            else
            {

                MessageBox.Show("Invalid Id Please try again");
                grdBooks.ItemsSource = db.Books.ToList();
            }
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var book = db.Books.Find(id); //week6

            if (book != null)
            {
                txtTitle.Text = book.Title;
                txtPrice.Text = book.Price.ToString();
                
            }
            else
            {
                txtTitle.Text = txtPrice.Text ="";
                MessageBox.Show("Invalid Id Please try again");
                grdBooks.ItemsSource = db.Books.ToList();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var books = (from book in db.Books
                        where book.Title.Contains(txtTitle.Text)
                        select book).ToList(); // week6

            if (books.Count > 0)
                grdBooks.ItemsSource = books;
            else
                MessageBox.Show("No Book Found");
        }
    }
}
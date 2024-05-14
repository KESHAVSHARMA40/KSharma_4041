using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week1EFIntroduction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {           

        BookDBEntities db = new BookDBEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            var books = db.Books.ToList();
            grdBooks.ItemsSource = books;

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book();
            newBook.Title = txtTitle.Text;
            newBook.Price = decimal.Parse(txtPrice.Text);

            db.Books.Add(newBook);
            db.SaveChanges();

            txtTitle.Text = "";
            txtPrice.Text = "";

            var books = db.Books.ToList();
            grdBooks.ItemsSource = books;

        }

        private void btnClearData_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtTitle.Text = "";
            txtPrice.Text = "";
            grdBooks.ItemsSource = null;

        }
    }
}

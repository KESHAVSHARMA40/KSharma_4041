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
using System.Xml.Linq;

namespace Practise_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BlogContext db = new BlogContext();

        public Post selectedItem { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var blogs = db.Blogs.ToList();
            dataGrid.ItemsSource = blogs;
           
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            // Add your edit logic here

           
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = listView.SelectedItem;

            // Check if an item is selected
            if (selectedItem != null)
            {
                // Check the type of the selected item
                if (selectedItem is Blog blog)
                {
                    // Delete blog logic here
                    db.Blogs.Remove(blog);
                    db.SaveChanges();
                }
                else if (selectedItem is Post post)
                {
                    // Delete post logic here
                    db.Posts.Remove(post);
                    db.SaveChanges();
                }
                else if (selectedItem is Comment comment)
                {
                    // Delete comment logic here
                    db.Comments.Remove(comment);
                    db.SaveChanges();
                }
            }
        }
    }
    }


       

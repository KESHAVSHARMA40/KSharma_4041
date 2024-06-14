using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Assignment1_KeshavSharma_4532854
{
    public partial class MainWindow : Window
    {
        ProductContext db = new ProductContext();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            var products = db.Products.ToList();
            GridProducts.ItemsSource = products;

        }
        private void LoadProducts()
        {
          var categories = db.Categories.ToList();
            GridProducts.ItemsSource = categories;
        }

        private void ButtonClearData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoadGrid();

        }

        private void ComboBoxCategories_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ComboBox.SelectedValue is int selectedCategoryId)
            {
                var products = db.Products.Where(p => p.CategoryId == selectedCategoryId).ToList();
                ComboBox.ItemsSource = products;
                LoadGrid();
                LoadProducts();
            }


        }

        private void ButtonSearchProduct_Click(object sender, RoutedEventArgs e)
        {
            string searchText = (string)TextBoxSearch.DataContext;
            var products = db.Products.Where(p => p.ProductName.ToLower().Contains(searchText)).ToList();
            GridProducts.ItemsSource = products;
            LoadGrid();
        }
    }
    }

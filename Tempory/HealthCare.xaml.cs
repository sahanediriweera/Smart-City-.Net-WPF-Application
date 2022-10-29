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

namespace Testing_GUI_Project_DataBase.Tempory
{
    /// <summary>
    /// Interaction logic for HealthCare.xaml
    /// </summary>
    public partial class HealthCare : UserControl
    {

        public HealthCare()
        {
            InitializeComponent();
            var products = getProducts();
            ListViewProducts.ItemsSource = products;
        }

        private List<Product> getProducts()
        {
            return new List<Product>() {
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2),
            new Product("123",12.2)
            };
        }
    }
}
